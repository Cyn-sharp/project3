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
using static System.Windows.Forms.DataFormats;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.Net.Mail;
using gymApp.Forms;



namespace gymApp
{
    public partial class Login : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\CYNDRICK\Desktop\Gymapp.accdb""";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace(" - ", "").ToLower();
            }
        }
        private void AddAdmin()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Admin  (Username, PasswordHash) VALUES (@Username, @PasswordHash)";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", txtAdmin.Text);
                    cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(txtPassword.Text)); // Hash before storing

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin user added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private bool VerifyLogin(string username, string password)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT PasswordHash FROM Admin WHERE Username = @Username";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string storedHash = result.ToString();
                        return storedHash == HashPassword(password); // Compare hashes
                    }
                }
            }
            return false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtAdmin.Text;  // Username input from user
            string password = txtPassword.Text;  // Password input from user

            string query = "SELECT * FROM Admin WHERE Username = @Username AND Password = @Password";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        conn.Open();
                        OleDbDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            // Admin found, login successful
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormMainMenu f = new FormMainMenu();
                            f.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ForgotPassword_Click(object sender, EventArgs e)
        {
            FormResetPassword rp = new FormResetPassword();
            rp.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtAdmin.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}
