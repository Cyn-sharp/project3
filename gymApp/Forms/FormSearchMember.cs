using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymApp.Forms
{

    public partial class FormSearchMember : Form
    {
        private string placeholderText = "🔍Type a Member Name...";
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\CYNDRICK\Desktop\Gymapp.accdb""";

        public FormSearchMember()
        {
            InitializeComponent();
            LoadTheme();
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

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == placeholderText)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = placeholderText;
                txtSearch.ForeColor = Color.Gray; 
            }
        }


        public string SelectedMemberID { get; private set; }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvSearchResult.SelectedRows.Count > 0)
            {
                SelectedMemberID = dgvSearchResult.SelectedRows[0].Cells["MemberID"].Value.ToString();
                this.DialogResult = DialogResult.OK; // Close the form and return OK
                this.Close();
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    string query = "SELECT MemberID, FirstName, LastName, Email FROM Members " +
                                   "WHERE FirstName LIKE @search OR LastName LIKE @search";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSearchResult.DataSource = dt;

                        foreach (DataRow row in dt.Rows)
                        {
                            row["MemberID"] = int.Parse(row["MemberID"].ToString()).ToString("000");
                        }

                        dgvSearchResult.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the 'ding' sound
                PerformSearch(); // Call the search method
            }
        }
        private void PerformSearch()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT MemberID, FirstName, LastName FROM Members " +
                               "WHERE FirstName LIKE @search OR LastName LIKE @search";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSearchResult.DataSource = dt;
                }
            }
        }

        private void FormSearchMember_Load(object sender, EventArgs e)
        {
            txtSearch.KeyDown += txtSearch_KeyDown;
            txtSearch.Text = placeholderText;
            txtSearch.ForeColor = Color.Gray; // Placeholder text color

            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            this.ActiveControl = btnSearch;
        }
    }
}
