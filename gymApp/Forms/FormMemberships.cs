using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymApp.Forms
{
    public partial class formMemberships : BaseForm
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\CYNDRICK\Desktop\Gymapp.accdb""";
        private int daysBeforeExpiry = 7;

        public formMemberships()
        {
            InitializeComponent();
            this.Text = "Membership Management";
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.TopLevel = false;
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColor.SecondaryColor;
        }
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            FormSearchMember searchForm = new FormSearchMember();

            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                string selectedID = searchForm.SelectedMemberID;
                MessageBox.Show("Selected Member ID: " + selectedID);
            }
        }

        private void LoadAllMemberships()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    // Safe query that won't fail if columns are missing
                    string query = @"
                        SELECT 
                            m.MemberID,
                            m.FirstName,
                            m.LastName,
                            m.ProgramEnrolled AS Program,
                            m.MembershipType AS Membership,
                            ms.StartDate,
                            ms.ExpiryDate
                        FROM Members m
                        LEFT JOIN Memberships ms ON m.MemberID = ms.MemberID
                        ORDER BY m.MemberID";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Ensure columns exist in the DataTable
                    if (!dt.Columns.Contains("ExpiryDate"))
                    {
                        dt.Columns.Add("ExpiryDate", typeof(DateTime));
                    }
                    if (!dt.Columns.Contains("StartDate"))
                    {
                        dt.Columns.Add("StartDate", typeof(DateTime));
                    }

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members: " + ex.Message);
            }
        }


        private void Memberships_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadAllMemberships();
            btnSoonToExpire.Click += btnSoontoExpire_Click;

            // Set up grid
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.CellFormatting += DgvMemberships_CellFormatting;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a membership to renew", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int membershipId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MemberID"].Value);
            RenewMembership(membershipId);
        }

        private void RenewMembership(int membershipId)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    // Get current membership details
                    string getQuery = "SELECT MembershipType, ExpiryDate FROM Memberships WHERE MembershipID = @ID";
                    OleDbCommand getCmd = new OleDbCommand(getQuery, conn);
                    getCmd.Parameters.AddWithValue("@ID", membershipId);

                    conn.Open();
                    OleDbDataReader reader = getCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string membershipType = reader["MembershipType"].ToString();
                        DateTime currentExpiry = Convert.ToDateTime(reader["ExpiryDate"]);
                        DateTime newExpiry = CalculateNewExpiry(membershipType, currentExpiry);

                        // Update membership
                        string updateQuery = "UPDATE Memberships SET ExpiryDate = @NewExpiry WHERE MembershipID = @ID";
                        OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@NewExpiry", newExpiry);
                        updateCmd.Parameters.AddWithValue("@ID", membershipId);

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Membership renewed successfully");
                            LoadAllMemberships();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error renewing membership: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DateTime CalculateNewExpiry(string membershipType, DateTime currentExpiry)
        {
            if (membershipType == "Annual")
            {
                return currentExpiry.AddYears(1);
            }
            else // Monthly
            {
                return currentExpiry.AddMonths(1);
            }
        }

        private void btnSoontoExpire_Click(object sender, EventArgs e)
        {
            LoadSoonToExpireMemberships();
        }


        private void LoadSoonToExpireMemberships()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    DateTime expiryThreshold = DateTime.Today.AddDays(daysBeforeExpiry);

                    string query = @"SELECT m.MemberID, mem.FirstName, mem.LastName, 
                                    mem.ProgramEnrolled, m.MembershipType, m.StartDate, m.ExpiryDate
                                    FROM Memberships m
                                    INNER JOIN Members mem ON m.MemberID = mem.MemberID
                                    WHERE m.ExpiryDate BETWEEN @Today AND @Threshold
                                    ORDER BY m.ExpiryDate ASC";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@Today", DateTime.Today);
                    adapter.SelectCommand.Parameters.AddWithValue("@Threshold", expiryThreshold);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Rename column for display
                    if (dt.Columns.Contains("MembershipType"))
                    {
                        dt.Columns["MembershipType"].ColumnName = "Membership";
                    }

                    dataGridView1.DataSource = dt;
                    ColorSoonToExpireRows();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading soon-to-expire memberships: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ColorSoonToExpireRows()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ExpiryDate"].Value != null &&
                    DateTime.TryParse(row.Cells["ExpiryDate"].Value.ToString(), out DateTime expiryDate))
                {
                    if (expiryDate <= DateTime.Today.AddDays(daysBeforeExpiry))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightSalmon;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                }
            }
        }
        private void btnSendReminders_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Send expiration reminders to all soon-to-expire members?", "Confirm",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SendExpirationReminders();
            }
        }
        private void SendExpirationReminders()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    DateTime expiryThreshold = DateTime.Today.AddDays(daysBeforeExpiry);

                    string query = @"SELECT mem.MemberID, mem.FirstName, mem.LastName, mem.Email, 
                           m.MembershipType, m.ExpiryDate
                           FROM Memberships m
                           INNER JOIN Members mem ON m.MemberID = mem.MemberID
                           WHERE m.ExpiryDate BETWEEN @Today AND @Threshold
                           AND mem.Email IS NOT NULL";

                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Today", DateTime.Today);
                    cmd.Parameters.AddWithValue("@Threshold", expiryThreshold);

                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string memberName = $"{reader["FirstName"]} {reader["LastName"]}";
                        string email = reader["Email"].ToString();
                        string membershipType = reader["MembershipType"].ToString();
                        DateTime expiryDate = Convert.ToDateTime(reader["ExpiryDate"]);

                        SendReminderEmail(email, memberName, membershipType, expiryDate);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending reminders: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SendReminderEmail(string toEmail, string memberName, string membershipType, DateTime expiryDate)
        {
            try
            {
                // Configure your SMTP client (example using System.Net.Mail)
                SmtpClient client = new SmtpClient("smtp.yourprovider.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("your@email.com", "yourpassword"),
                    EnableSsl = true
                };

                MailMessage message = new MailMessage
                {
                    From = new MailAddress("your@email.com"),
                    Subject = $"Your {membershipType} Membership Expires Soon",
                    Body = $"Dear {memberName},\n\n" +
                          $"Your {membershipType} membership will expire on {expiryDate:dd/MM/yyyy}.\n" +
                          $"Please renew to continue enjoying our services.\n\n" +
                          $"Best regards,\nYour Gym Team",
                    IsBodyHtml = false
                };

                message.To.Add(toEmail);
                client.Send(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void btnShowStats_Click(object sender, EventArgs e)
        {
            ShowMembershipStatistics();
        }

        private void ShowMembershipStatistics()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    string query = @"SELECT 
                           SUM(IIF(Membership = 'Annual', 1, 0)) AS AnnualCount,
                           SUM(IIF(Membership = 'Monthly', 1, 0)) AS MonthlyCount,
                           COUNT(*) AS Total,
                           SUM(IIF(ExpiryDate < DATE(), 1, 0)) AS ExpiredCount,
                           SUM(IIF(ExpiryDate BETWEEN DATE() AND DATEADD('d', 7, DATE()), 1, 0)) AS SoonToExpireCount
                           FROM Memberships";

                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string stats = $"Membership Statistics:\n\n" +
                                     $"Annual Memberships: {reader["AnnualCount"]}\n" +
                                     $"Monthly Memberships: {reader["MonthlyCount"]}\n" +
                                     $"Total Memberships: {reader["Total"]}\n" +
                                     $"Expired Memberships: {reader["ExpiredCount"]}\n" +
                                     $"Soon-to-Expire: {reader["SoonToExpireCount"]}";

                        MessageBox.Show(stats, "Membership Statistics",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading statistics: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DgvMemberships_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;

            // Format MemberID as 4-digit number
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colMemberID")
            {
                e.Value = $"{Convert.ToInt32(e.Value):D4}";
                e.FormattingApplied = true;
            }

            // Handle null/empty program values
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colProgram" && string.IsNullOrEmpty(e.Value?.ToString()))
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a member to edit.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            int memberId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MemberID"].Value);

            EditMemberForm editMemberForm = new EditMemberForm(memberId);
            if (editMemberForm.ShowDialog() == DialogResult.OK)
            {
                LoadAllMemberships();

            }



        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this member?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (OleDbConnection conn = new OleDbConnection(connectionString))
                    {
                        string query = "DELETE FROM Members WHERE MemberID=@MemberID";

                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Member Deleted Successfully!");
                            LoadAllMemberships(); // Refresh the DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells["MemberID"].Value == null)
            {
                MessageBox.Show("Please select a valid member to activate.", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Safely get MemberID with error handling
            if (!int.TryParse(dataGridView1.CurrentRow.Cells["MemberID"].Value.ToString(), out int memberId))
            {
                MessageBox.Show("Invalid Member ID format.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ActivateMembership(memberId);
        }


        private void ActivateMembership(int memberId)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // 1. Get member details
                    string memberQuery = "SELECT MembershipType FROM Members WHERE MemberID = ?";
                    string membershipType;

                    using (OleDbCommand memberCmd = new OleDbCommand(memberQuery, conn))
                    {
                        memberCmd.Parameters.AddWithValue("?", memberId);
                        var result = memberCmd.ExecuteScalar();

                        if (result == null || string.IsNullOrEmpty(result.ToString()))
                        {
                            MessageBox.Show("No membership type found for this member.", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        membershipType = result.ToString();
                    }

                    // 2. Calculate dates
                    DateTime startDate = DateTime.Today;
                    DateTime expiryDate = membershipType.Equals("Annual", StringComparison.OrdinalIgnoreCase)
                        ? startDate.AddYears(1)
                        : startDate.AddMonths(1);

                    // 3. Check if membership exists
                    bool exists;
                    string checkQuery = "SELECT COUNT(*) FROM Memberships WHERE MemberID = ?";

                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("?", memberId);
                        exists = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0;
                    }

                    // 4. Insert or Update
                    string actionQuery = exists
                        ? "UPDATE Memberships SET MembershipType = ?, StartDate = ?, ExpiryDate = ? WHERE MemberID = ?"
                        : "INSERT INTO Memberships (MemberID, MembershipType, StartDate, ExpiryDate) VALUES (?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(actionQuery, conn))
                    {
                        if (exists)
                        {
                            cmd.Parameters.AddWithValue("?", membershipType);
                            cmd.Parameters.AddWithValue("?", startDate);
                            cmd.Parameters.AddWithValue("?", expiryDate);
                            cmd.Parameters.AddWithValue("?", memberId);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("?", memberId);
                            cmd.Parameters.AddWithValue("?", membershipType);
                            cmd.Parameters.AddWithValue("?", startDate);
                            cmd.Parameters.AddWithValue("?", expiryDate);
                        }

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Membership {(exists ? "renewed" : "activated")} successfully!\n" +
                                          $"Expires on: {expiryDate:dd/MM/yyyy}",
                                          "Success",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);
                            LoadAllMemberships();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error activating membership: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetMembershipTypeFromMembers(int memberId)
        {
            string membershipType = "";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT MembershipType FROM Members WHERE MemberID = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", memberId);

                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                    membershipType = result.ToString();
            }

            return membershipType;
        }
    }

}
