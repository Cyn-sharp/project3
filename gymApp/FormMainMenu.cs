using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gymApp
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            btnRefreshForm.Visible = false;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 12.5F);
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnRefreshForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 11F);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMembers(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormInstructor(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEquipment(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAbout(), sender);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.formMemberships(), sender);
        }

        private void btnRefreshForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitle.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnRefreshForm.Visible = false;
        }
    }
}
