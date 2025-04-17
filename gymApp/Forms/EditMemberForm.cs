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
    public partial class EditMemberForm : Form
    {
        private int memberId;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\CYNDRICK\Desktop\Gymapp.accdb""";


        public EditMemberForm(int id)
        {
            InitializeComponent();
            memberId = id;
            LoadMemberData();
            txtID.ReadOnly = true;
            txtID.TabStop = false;
            LoadTheme   ();
        }
        private void LoadMemberData()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT * FROM Members WHERE MemberID = @ID";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", memberId);
                conn.Open();

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFirstName.Text = reader["FirstName"].ToString();
                    txtLastName.Text = reader["LastName"].ToString();
                    txtEmail.Text = reader["Email"].ToString(); // Add other fields as needed
                    txtID.Text = reader["MemberID"].ToString();
                }
            }
        }
        public EditMemberForm()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void EditMemberForm_Load(object sender, EventArgs e)
        {

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
        }



        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                    string updateQuery = @"UPDATE Members 
                               SET FirstName = @FirstName, LastName = @LastName, Email = @Email 
                               WHERE MemberID = @ID";

                    OleDbCommand cmd = new OleDbCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@ID", memberId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member updated successfully.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
        }
    }
}
