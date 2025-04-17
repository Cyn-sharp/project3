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
    public partial class FormInstructor : BaseForm
    {
        private int currentInstructorId = -1;
        private bool isEditMode = false;
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\CYNDRICK\Desktop\Gymapp.accdb""";
        public FormInstructor()
        {
            InitializeComponent();
        }

        void LoadInstructor()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    string query = "SELECT InstructorID, FirstName, LastName, Specialization, Gender  FROM Instructors ORDER BY InstructorID ASC";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvInstructors.DataSource = dt;
                }
            }
            catch (Exception e)
            {
                {
                    MessageBox.Show("Error " + e);
                }
            }
        }
        private void SearchInstructors(string searchTerm)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    string query = @"SELECT InstructorID, FirstName, LastName, Specialization, Gender 
                           FROM Instructors 
                           WHERE FirstName LIKE @SearchTerm 
                           OR LastName LIKE @SearchTerm 
                           OR Specialization LIKE @SearchTerm
                           ORDER BY LastName, FirstName";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvInstructors.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No instructors found matching your search", "No Results",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching instructors: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            label6.ForeColor = ThemeColor.SecondaryColor;
            label4.ForeColor = ThemeColor.PrimaryColor;
        }

        private void FormInstructor_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadInstructor();
            LoadSpecializations();
            txtSearch.PlaceholderText = "Search by name or specialization...";
            dgvInstructors.CellClick += dgvInstructors_CellClick;
        }

        private void AddInstructor(string firstName, string lastName, string specialization, string gender)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Instructors (FirstName, LastName, Specialization, Gender) VALUES (@FirstName, @LastName, @Specialization, @Gender)";


                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Specialization", specialization);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Instructor added successfully");
        }

        private void LoadSpecializations()
        {
            cboSpecialization.Items.Clear();
            cboSpecialization.Items.Add("Strength Training");
            cboSpecialization.Items.Add("Cardio");
            cboSpecialization.Items.Add("Yoga");
            cboSpecialization.Items.Add("CrossFit");
            cboSpecialization.SelectedIndex = 0; // Select first item by default
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("First Name and Last Name are required", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gender = GetSelectedGender();
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isEditMode)
            {
                UpdateInstructor(currentInstructorId, txtFirstName.Text, txtLastName.Text,
                                cboSpecialization.Text, gender);
            }
            else
            {
                AddInstructor(txtFirstName.Text, txtLastName.Text,
                             cboSpecialization.Text, gender);
            }
        }
        private void UpdateInstructor(int instructorId, string firstName, string lastName,
                            string specialization, string gender)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Instructors SET 
                           FirstName = @FirstName,
                           LastName = @LastName,
                           Specialization = @Specialization,
                           Gender = @Gender
                           WHERE InstructorID = @InstructorID";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Specialization", specialization);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@InstructorID", instructorId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Instructor updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("No instructor was updated");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating instructor: {ex.Message}");
            }

            LoadInstructor();
        }

        private string GetSelectedGender()
        {
            if (rdoMale.Checked)
                return "Male";
            else if (rdoFemale.Checked)
                return "Female";
            else
                return ""; // In case nothing is selected
        }

        private void SetGender(string gender)
        {
            if (gender == "Male")
                rdoMale.Checked = true;
            else if (gender == "Female")
                rdoFemale.Checked = true;
        }
        private void ClearTextBoxes()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            cboSpecialization = null;
            rdoFemale = null;
            rdoMale = null;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            LoadInstructor();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvInstructors.CurrentRow == null)
            {
                MessageBox.Show("Please select an instructor to edit", "No Selection",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isEditMode = true;
            currentInstructorId = Convert.ToInt32(dgvInstructors.CurrentRow.Cells["InstructorID"].Value);

            // Load selected instructor data into form
            txtFirstName.Text = dgvInstructors.CurrentRow.Cells["FirstName"].Value.ToString();
            txtLastName.Text = dgvInstructors.CurrentRow.Cells["LastName"].Value.ToString();
            cboSpecialization.Text = dgvInstructors.CurrentRow.Cells["Specialization"].Value.ToString();
            SetGender(dgvInstructors.CurrentRow.Cells["Gender"].Value.ToString());

            btnAdd.Text = "Update"; // Change button text
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvInstructors.CurrentRow == null)
            {
                MessageBox.Show("Please select an instructor to delete", "No Selection",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this instructor?", "Confirm Delete",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int instructorId = Convert.ToInt32(dgvInstructors.CurrentRow.Cells["InstructorID"].Value);
                DeleteInstructor(instructorId);
            }
        }
        private void DeleteInstructor(int instructorId)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Instructors WHERE InstructorID = @InstructorID";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@InstructorID", instructorId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Instructor deleted successfully");
                            LoadInstructor();
                        }
                        else
                        {
                            MessageBox.Show("No instructor was deleted");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting instructor: {ex.Message}");
            }
        }

        private void dgvInstructors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid row (not header)
            if (e.RowIndex >= 0 && dgvInstructors.Rows[e.RowIndex].Cells["InstructorID"].Value != null)
            {
                DataGridViewRow row = dgvInstructors.Rows[e.RowIndex];

                try
                {
                    // Store the ID for potential operations
                    currentInstructorId = Convert.ToInt32(row.Cells["InstructorID"].Value);

                    // Display data in form with null checks
                    txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
                    txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
                    cboSpecialization.Text = row.Cells["Specialization"].Value?.ToString() ?? "";

                    // Handle gender with null check
                    string gender = row.Cells["Gender"].Value?.ToString() ?? "";
                    SetGender(gender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading instructor data: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                SearchInstructors(txtSearch.Text.Trim());
            }
            else
            {
                MessageBox.Show("Please enter a search term", "Search Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadInstructor();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
                e.Handled = true;
            }
        }
        private void SearchInstructorsAdvanced(string searchTerm, string genderFilter = "")
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    string query = @"SELECT InstructorID, FirstName, LastName, Specialization, Gender 
                           FROM Instructors 
                           WHERE (FirstName LIKE @SearchTerm 
                           OR LastName LIKE @SearchTerm 
                           OR Specialization LIKE @SearchTerm)";

                    if (!string.IsNullOrEmpty(genderFilter))
                    {
                        query += " AND Gender = @Gender";
                    }

                    query += " ORDER BY LastName, FirstName";

                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                    if (!string.IsNullOrEmpty(genderFilter))
                    {
                        cmd.Parameters.AddWithValue("@Gender", genderFilter);
                    }

                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvInstructors.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching instructors: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
