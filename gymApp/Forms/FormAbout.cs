using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymApp.Forms
{
    public partial class FormAbout : BaseForm
    {
        public FormAbout()
        {
            InitializeComponent();
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

        private void FormAbout_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
