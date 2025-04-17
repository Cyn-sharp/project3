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
using System.Security.Cryptography;


namespace gymApp.Forms
{
    public partial class FormResetPassword : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\CYNDRICK\Desktop\Gymapp.accdb";
        public FormResetPassword()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                // Check if the username exists
                string checkQuery = "SELECT COUNT(*) FROM Admin WHERE Username = @Username";
                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show("Username not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Update the password
                string updateQuery = "UPDATE Admin  SET PasswordHash = @NewPassword WHERE Username = @Username";
                using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@NewPassword", HashPassword(txtNewPassword.Text)); // Encrypt new password
                    updateCmd.Parameters.AddWithValue("@Username", txtUsername.Text);

                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the reset form after successful reset
                }
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
    }
}
