namespace gymApp.Forms
{
    partial class FormResetPassword
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
            txtUsername = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            txtNewPassword = new Label();
            textBox3 = new TextBox();
            txtConfirmPassword = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(109, 17);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(146, 23);
            txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 20);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 23);
            textBox2.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            txtNewPassword.AutoSize = true;
            txtNewPassword.Location = new Point(-1, 52);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(87, 15);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.Text = "New Password:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(109, 73);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(146, 23);
            textBox3.TabIndex = 0;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.AutoSize = true;
            txtConfirmPassword.Location = new Point(-1, 82);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(107, 15);
            txtConfirmPassword.TabIndex = 1;
            txtConfirmPassword.Text = "Confirm Password:";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(164, 120);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(91, 31);
            btnReset.TabIndex = 2;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // FormResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 173);
            Controls.Add(btnReset);
            Controls.Add(txtConfirmPassword);
            Controls.Add(textBox3);
            Controls.Add(txtNewPassword);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Name = "FormResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reset Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label label1;
        private TextBox textBox2;
        private Label txtNewPassword;
        private TextBox textBox3;
        private Label txtConfirmPassword;
        private Button btnReset;
    }
}