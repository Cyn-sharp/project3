using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace gymApp.Forms
{
    public partial class FormEquipment : BaseForm
    {
        private int currentEquipmentId = -1;
        private bool isEditMode = false;

        public FormEquipment()
        {
            InitializeComponent();
        }

        private void FormEquipment_Load(object sender, EventArgs e)
        {
            InitializeStatusRadioButtons();
            LoadEquipment();
        }

        private void InitializeStatusRadioButtons()
        {
            rdoAvailable.Tag = "Available";
            rdoNotAvailable.Tag = "Unavailable";
            rdoUnderM.Tag = "Under Maintenance";
        }

        private void LoadEquipment()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    string query = "SELECT EquipmentID, EquipmentName, Availability FROM Equipment ORDER BY EquipmentId ASC";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dataGridView1.Columns.Contains("EquipmentID"))
                    {
                        dataGridView1.Columns["EquipmentID"].DefaultCellStyle.Format = "0000";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading equipment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                btnEdit_Click(sender, e);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEquipmentName.Text))
            {
                MessageBox.Show("Equipment name is required", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = GetSelectedStatus();
            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please select availability status", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Equipment (EquipmentName, Availability) VALUES (@Name, @Status)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtEquipmentName.Text);
                        cmd.Parameters.AddWithValue("@Status", status);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Equipment added successfully");
                        ResetForm();
                        LoadEquipment();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding equipment: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentEquipmentId == -1)
            {
                MessageBox.Show("Please select equipment to edit", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEquipmentName.Text))
            {
                MessageBox.Show("Equipment name is required", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = GetSelectedStatus();
            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please select availability status", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Equipment WHERE EquipmentID = @ID";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ID", currentEquipmentId);
                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (exists == 0)
                        {
                            MessageBox.Show("Equipment not found in database",
                                          "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string updateQuery = @"UPDATE Equipment SET 
                                EquipmentName = @Name, 
                                Availability = @Status 
                                WHERE EquipmentID = @ID";

                    using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtEquipmentName.Text);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@ID", currentEquipmentId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Equipment updated successfully");
                            ResetForm();
                            LoadEquipment();
                        }
                        else
                        {
                            MessageBox.Show("No changes were made to the equipment");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating equipment: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            txtEquipmentName.Clear();
            rdoAvailable.Checked = false;
            rdoNotAvailable.Checked = false;
            rdoUnderM.Checked = false;
            currentEquipmentId = -1;
            isEditMode = false;
            btnAdd.Text = "ADD";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.ClearSelection();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (currentEquipmentId == -1)
            {
                MessageBox.Show("Please select equipment to delete", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this equipment?", "Confirm Delete",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (OleDbConnection conn = new OleDbConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Equipment WHERE EquipmentID = @ID";

                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", currentEquipmentId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Equipment deleted successfully");
                                LoadEquipment();
                                currentEquipmentId = -1;
                            }
                            else
                            {
                                MessageBox.Show("No equipment was deleted", "Warning",
                                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting equipment: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetSelectedStatus()
        {
            if (rdoAvailable.Checked) return "Available";
            if (rdoNotAvailable.Checked) return "Unavailable";
            if (rdoUnderM.Checked) return "Under Maintenance";
            return "";
        }

        private void SetSelectedStatus(string status)
        {
            rdoAvailable.Checked = (status == "Available");
            rdoNotAvailable.Checked = (status == "Unavailable");
            rdoUnderM.Checked = (status == "Under Maintenance");
        }

        private void dgvEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["EquipmentID"].Value != null)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                currentEquipmentId = Convert.ToInt32(row.Cells["EquipmentID"].Value);
                txtEquipmentName.Text = row.Cells["EquipmentName"].Value?.ToString() ?? "";
                SetSelectedStatus(row.Cells["Availability"].Value?.ToString() ?? "");
                isEditMode = true;
                btnAdd.Text = "UPDATE";
            }
        }

        private void dgvEquipment_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["Availability"].Value != null)
            {
                string status = dataGridView1.Rows[e.RowIndex].Cells["Availability"].Value.ToString();

                switch (status)
                {
                    case "Available":
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    case "Unavailable":
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                        break;
                    case "Under Maintenance":
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                        break;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                SearchEquipment(txtSearch.Text.Trim());
            }
            else
            {
                LoadEquipment();
            }
        }

        private void SearchEquipment(string searchTerm)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    string query = @"SELECT EquipmentID, EquipmentName, Availability 
                           FROM Equipment 
                           WHERE EquipmentName LIKE @SearchTerm
                           OR Availability LIKE @SearchTerm
                           ORDER BY EquipmentName";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No equipment found matching your search", "No Results",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching equipment: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEquipment();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}