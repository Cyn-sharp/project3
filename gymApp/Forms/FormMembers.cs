using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace gymApp.Forms
{
    public partial class FormMembers : BaseForm
    {
        public FormMembers()
        {
            InitializeComponent();
        }

        private void FormMembers_Load(object sender, EventArgs e)
        {
            LoadTheme(this); // from BaseForm
            LoadMembers();
            txtID.Text = "AUTO";
            txtID.Enabled = false;
        }

        private void LoadMembers()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    string query = "SELECT MemberID, FirstName, LastName, Email, Birthdate, Gender, MembershipType FROM Members ORDER BY MemberID ASC";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members: " + ex.Message);
            }
        }

        private string GetNextFormattedId()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                // Handle both text and numeric IDs
                string query = "SELECT MAX(Val(MemberID)) FROM Members";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    int lastId = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
                    return (lastId + 1).ToString("D4"); // 4-digit format
                }
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("First Name and Last Name are required!", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get all values for confirmation
            string gender = rbMale.Checked ? "Male" :
                          rbFemale.Checked ? "Female" :
                          rbNon.Checked ? "Non-binary" : "";

            string membershipType = cbAnnual.Checked ? "Annual" :
                                  cbMonthly.Checked ? "Monthly" :
                                  string.Empty;

            // Generate a preview ID (won't be saved until confirmation)
            string previewId = (GetHighestMemberId() + 1).ToString("D4");

            // Display confirmation panel with entered values
            lblConfirmID.Text = previewId;
            lblConfirmName.Text = $"{txtFirstName.Text} {txtLastName.Text}";
            lblConfirmEmail.Text = string.IsNullOrWhiteSpace(txtEmail.Text) ? "N/A" : txtEmail.Text;
            lblConfirmBirth.Text = dtpBirthdate.Checked ? dtpBirthdate.Value.ToShortDateString() : "N/A";
            lblConfirmGender.Text = string.IsNullOrEmpty(gender) ? "N/A" : gender;
            lblConfirmMembership.Text = string.IsNullOrEmpty(membershipType) ? "N/A" : membershipType;
            lblConfirmProgram.Text = cbProgram.SelectedItem?.ToString() ?? "N/A";

            // Show confirmation panel
            panelConfirmation.Visible = true;
        }

        private int GetHighestMemberId()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MAX(VAL(MemberID)) FROM Members";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    return (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
                }
            }
        }

        private string GetSelectedGender()
        {
            if (rbMale.Checked) return "Male";
            if (rbFemale.Checked) return "Female";
            if (rbNon.Checked) return "Non-binary";
            return "";
        }

        private string GetSelectedMembership()
        {
            if (cbAnnual.Checked) return "Annual";
            if (cbMonthly.Checked) return "Monthly";
            return "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtID.Text = "AUTO";
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            rbMale.Checked = rbFemale.Checked = rbNon.Checked = false;
            cbAnnual.Checked = cbMonthly.Checked = false;
            dtpBirthdate.Checked = false;
        }

        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfrimAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // Get the actual ID to use (should match the preview)
                    string newId = (GetHighestMemberId() + 1).ToString("D4");

                    // Prepare insert query
                    string insertQuery = @"INSERT INTO Members 
                                (MemberID, FirstName, LastName, Email, Birthdate, Gender, MembershipType, ProgramEnrolled) 
                                VALUES 
                                (@MemberID, @FirstName, @LastName, @Email, @Birthdate, @Gender, @MembershipType, @ProgramEnrolled)";

                    using (OleDbCommand cmd = new OleDbCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", newId);
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@Email",
                            string.IsNullOrWhiteSpace(txtEmail.Text) ? DBNull.Value : (object)txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Birthdate",
                            dtpBirthdate.Checked ? dtpBirthdate.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Gender",
                            GetSelectedGender() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@MembershipType",
                            GetSelectedMembership() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@ProgramEnrolled",
                            cbProgram.SelectedItem?.ToString() ?? (object)DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Member added successfully!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelConfirmation.Visible = false;
                LoadMembers(); // Refresh grid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding member: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string GetNextMemberId(OleDbConnection conn)
        {
            // Get the highest existing numeric ID
            string query = "SELECT MAX(VAL(MemberID)) FROM Members";
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();
                int maxId = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
                return (maxId + 1).ToString("D4"); // Format as 4-digit string
            }
        }


        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            panelConfirmation.Visible = false;
        }
    }
}
