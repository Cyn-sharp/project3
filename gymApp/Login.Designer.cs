namespace gymApp
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            btnClear = new Label();
            txtAdmin = new TextBox();
            txtPassword = new TextBox();
            btnExit = new Label();
            btnForgot = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(103, 122);
            label1.Name = "label1";
            label1.Size = new Size(114, 36);
            label1.TabIndex = 1;
            label1.Text = "LOG IN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 217);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.Location = new Point(36, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(36, 283);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.Location = new Point(36, 314);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 117, 214);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(36, 357);
            button1.Name = "button1";
            button1.Size = new Size(236, 33);
            button1.TabIndex = 4;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.FromArgb(0, 117, 214);
            btnClear.Location = new Point(36, 432);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(91, 16);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear Fields";
            btnClear.Click += btnClear_Click;
            // 
            // txtAdmin
            // 
            txtAdmin.BorderStyle = BorderStyle.None;
            txtAdmin.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAdmin.ForeColor = Color.FromArgb(0, 117, 214);
            txtAdmin.Location = new Point(67, 219);
            txtAdmin.Multiline = true;
            txtAdmin.Name = "txtAdmin";
            txtAdmin.Size = new Size(205, 23);
            txtAdmin.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(0, 117, 214);
            txtPassword.Location = new Point(67, 283);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(205, 25);
            txtPassword.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(0, 117, 214);
            btnExit.Location = new Point(135, 402);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 16);
            btnExit.TabIndex = 5;
            btnExit.Text = "EXIT";
            btnExit.Click += btnExit_Click;
            // 
            // btnForgot
            // 
            btnForgot.AutoSize = true;
            btnForgot.Cursor = Cursors.Hand;
            btnForgot.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnForgot.ForeColor = Color.FromArgb(0, 117, 214);
            btnForgot.Location = new Point(148, 328);
            btnForgot.Name = "btnForgot";
            btnForgot.Size = new Size(124, 16);
            btnForgot.TabIndex = 5;
            btnForgot.Text = "Forgot Password";
            btnForgot.Click += ForgotPassword_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(308, 486);
            Controls.Add(txtPassword);
            Controls.Add(txtAdmin);
            Controls.Add(btnExit);
            Controls.Add(btnForgot);
            Controls.Add(btnClear);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button button1;
        private Label btnClear;
        private TextBox txtAdmin;
        private TextBox txtPassword;
        private Label btnExit;
        private Label btnForgot;
    }
}