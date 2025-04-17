namespace gymApp.Forms
{
    partial class EditMemberForm
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
            txtEmail = new TextBox();
            label4 = new Label();
            txtID = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnSave = new Button();
            label6 = new Label();
            Cancel = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(95, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(139, 23);
            txtEmail.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 144);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "Email:";
            // 
            // txtID
            // 
            txtID.Location = new Point(95, 52);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "'0000'";
            txtID.Size = new Size(53, 23);
            txtID.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 60);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 10;
            label3.Text = "ID:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(95, 110);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(139, 23);
            txtLastName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 118);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 9;
            label2.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(95, 81);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(139, 23);
            txtFirstName.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 89);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 14;
            label1.Text = "First Name:";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(223, 170);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 28);
            btnSave.TabIndex = 26;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 9);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 27;
            label6.Text = "EDIT MEMBER";
            // 
            // Cancel
            // 
            Cancel.FlatStyle = FlatStyle.Flat;
            Cancel.ImageAlign = ContentAlignment.MiddleLeft;
            Cancel.Location = new Point(131, 170);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(86, 28);
            Cancel.TabIndex = 26;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // EditMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 210);
            Controls.Add(label6);
            Controls.Add(Cancel);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditMemberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditMemberForm";
            Load += EditMemberForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtID;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnSave;
        private Label label6;
        private Button Cancel;
    }
}