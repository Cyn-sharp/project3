using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymApp.Forms
{
    public partial class FormAttendance : BaseForm
    {
        public FormAttendance()
        {
            InitializeComponent();
        }

        private void FormAttendance_Load(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT MemberID, FirstName & ' ' & LastName AS FullName FROM Members";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Ensure MemberID column is treated as numeric
                dt.Columns["MemberID"].DataType = typeof(int);

                cmbMembers.DataSource = dt;
                cmbMembers.DisplayMember = "FullName";
                cmbMembers.ValueMember = "MemberID";
            }

            dtpDate.Value = DateTime.Today;
            LoadAttendanceData();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validate member selection
                if (cmbMembers.SelectedValue == null || !(cmbMembers.SelectedValue is int))
                {
                    MessageBox.Show("Please select a valid member.");
                    return;
                }

                int memberId = (int)cmbMembers.SelectedValue;

                // 2. Use this EXACT parameter format for Access
                string query = "INSERT INTO Attendance (MemberID, CheckInTime) VALUES (?, ?)";

                using (OleDbConnection conn = new OleDbConnection(connectionString))
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    // 3. Add parameters in EXACT order of the question marks
                    cmd.Parameters.Add("MemberID", OleDbType.Integer).Value = memberId;
                    cmd.Parameters.Add("CheckInTime", OleDbType.Date).Value = DateTime.Now;

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully checked in!");
                        LoadAttendanceData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Check-in failed. Please try again.\n\nError details: {ex.Message}");
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validate member selection
                if (cmbMembers.SelectedValue == null)
                {
                    MessageBox.Show("Please select a member first.");
                    return;
                }

                int memberId;
                if (!int.TryParse(cmbMembers.SelectedValue.ToString(), out memberId))
                {
                    MessageBox.Show("Invalid member selected.");
                    return;
                }

                // 2. Get the current date (without time)
                DateTime today = DateTime.Today;

                // 3. Set up the query to update the CheckOutTime for today
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    string query = @"UPDATE Attendance SET CheckOutTime = ? 
                        WHERE MemberID = ? 
                        AND CheckInTime >= ? 
                        AND CheckInTime < ? 
                        AND CheckOutTime IS NULL";

                    OleDbCommand cmd = new OleDbCommand(query, conn);

                    // 4. Add parameters in the correct order
                    cmd.Parameters.Add("CheckOutTime", OleDbType.Date).Value = DateTime.Now;
                    cmd.Parameters.Add("MemberID", OleDbType.Integer).Value = memberId;

                    // 5. Ensure we're comparing based on just the date portion
                    cmd.Parameters.Add("StartDate", OleDbType.Date).Value = today;
                    cmd.Parameters.Add("EndDate", OleDbType.Date).Value = today.AddDays(1);

                    // 6. Open the connection and execute the query
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    // 7. Show appropriate message based on the result
                    MessageBox.Show(rows > 0 ? "Check-out recorded!" : "No check-in found for today.");
                    LoadAttendanceData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Check-out error: {ex.Message}");
            }
        }

        private void LoadAttendanceData()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    string query = @"SELECT m.FirstName & ' ' & m.LastName AS MemberName, 
                         a.CheckInTime, a.CheckOutTime 
                         FROM Attendance a
                         INNER JOIN Members m ON a.MemberID = m.MemberID
                         ORDER BY a.CheckInTime DESC";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvAttendance.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance: " + ex.Message);
            }
        }
    }
}
