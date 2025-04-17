using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymApp.Forms
{
    public class BaseForm : Form
    {
        protected string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\CYNDRICK\Desktop\Gymapp.accdb""";


        protected void LoadTheme(Control Parent)
        {
            foreach (Control control in Parent.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        protected string GetMembershipType(int memberId)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT MembershipType FROM Members WHERE MemberID = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", memberId);

                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "";
            }
        }
        protected DateTime CalculateExpiryDate(string membershipType)
        {
            DateTime startDate = DateTime.Today;
            return membershipType == "Annual"
                ? startDate.AddYears(1)
                : startDate.AddMonths(1);
        }
    }
}
