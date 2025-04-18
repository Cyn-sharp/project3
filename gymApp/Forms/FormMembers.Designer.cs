namespace gymApp.Forms
{
    partial class FormMembers
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
            btnAddMember = new Button();
            label1 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            dtpBirthdate = new DateTimePicker();
            label7 = new Label();
            gender = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            rbNon = new RadioButton();
            richTextBox1 = new RichTextBox();
            cbAnnual = new CheckBox();
            cbMonthly = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnRefresh = new Button();
            cbProgram = new ComboBox();
            label5 = new Label();
            panelConfirmation = new Panel();
            lblConfirmProgram = new Label();
            lblConfirmMembership = new Label();
            lblConfirmGender = new Label();
            lblConfirmBirth = new Label();
            lblConfirmEmail = new Label();
            lblConfirmName = new Label();
            lblConfirmID = new Label();
            btnCancelAdd = new Button();
            btnConfrimAdd = new Button();
            richTextBox2 = new RichTextBox();
            label8 = new Label();
            panelConfirmation.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddMember
            // 
            btnAddMember.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddMember.FlatStyle = FlatStyle.Flat;
            btnAddMember.Location = new Point(23, 400);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(98, 38);
            btnAddMember.TabIndex = 0;
            btnAddMember.Text = "ADD";
            btnAddMember.UseVisualStyleBackColor = true;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 72);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(93, 64);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(139, 23);
            txtFirstName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 101);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(93, 93);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(139, 23);
            txtLastName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 43);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(93, 35);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "'0000'";
            txtID.Size = new Size(53, 23);
            txtID.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 127);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 1;
            label4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(93, 119);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(139, 23);
            txtEmail.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(23, 263);
            label6.Name = "label6";
            label6.Size = new Size(168, 28);
            label6.TabIndex = 1;
            label6.Text = "Membership Type";
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Location = new Point(93, 159);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(200, 23);
            dtpBirthdate.TabIndex = 5;
            dtpBirthdate.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 165);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 1;
            label7.Text = "Birthdate:";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI", 9F);
            gender.Location = new Point(23, 195);
            gender.Name = "gender";
            gender.Size = new Size(48, 15);
            gender.TabIndex = 1;
            gender.Text = "Gender:";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(74, 195);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 3;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(131, 195);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 3;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbNon
            // 
            rbNon.AutoSize = true;
            rbNon.Location = new Point(200, 195);
            rbNon.Name = "rbNon";
            rbNon.Size = new Size(92, 19);
            rbNon.TabIndex = 3;
            rbNon.TabStop = true;
            rbNon.Text = "Non - binary";
            rbNon.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            richTextBox1.Location = new Point(131, 295);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(135, 61);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "1000 - Annual\n\n\n90 - Monthly";
            // 
            // cbAnnual
            // 
            cbAnnual.AutoSize = true;
            cbAnnual.Location = new Point(52, 294);
            cbAnnual.Name = "cbAnnual";
            cbAnnual.Size = new Size(64, 19);
            cbAnnual.TabIndex = 7;
            cbAnnual.Text = "Annual";
            cbAnnual.UseVisualStyleBackColor = true;
            // 
            // cbMonthly
            // 
            cbMonthly.AutoSize = true;
            cbMonthly.Location = new Point(52, 337);
            cbMonthly.Name = "cbMonthly";
            cbMonthly.Size = new Size(71, 19);
            cbMonthly.TabIndex = 7;
            cbMonthly.Text = "Monthly";
            cbMonthly.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(23, 366);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(67, 28);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "Weight Loss", "Muscle Building", "Cardio Training", "Yoga & Flexibility", "Sport Conditioning" });
            cbProgram.Location = new Point(85, 220);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(153, 23);
            cbProgram.TabIndex = 9;
            cbProgram.SelectedIndexChanged += cbProgram_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(23, 228);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 10;
            label5.Text = "Program:";
            // 
            // panelConfirmation
            // 
            panelConfirmation.Controls.Add(lblConfirmProgram);
            panelConfirmation.Controls.Add(lblConfirmMembership);
            panelConfirmation.Controls.Add(lblConfirmGender);
            panelConfirmation.Controls.Add(lblConfirmBirth);
            panelConfirmation.Controls.Add(lblConfirmEmail);
            panelConfirmation.Controls.Add(lblConfirmName);
            panelConfirmation.Controls.Add(lblConfirmID);
            panelConfirmation.Controls.Add(btnCancelAdd);
            panelConfirmation.Controls.Add(btnConfrimAdd);
            panelConfirmation.Controls.Add(richTextBox2);
            panelConfirmation.Controls.Add(label8);
            panelConfirmation.Dock = DockStyle.Right;
            panelConfirmation.Location = new Point(371, 0);
            panelConfirmation.Name = "panelConfirmation";
            panelConfirmation.Size = new Size(429, 450);
            panelConfirmation.TabIndex = 11;
            panelConfirmation.Visible = false;
            // 
            // lblConfirmProgram
            // 
            lblConfirmProgram.AutoSize = true;
            lblConfirmProgram.BackColor = SystemColors.ButtonHighlight;
            lblConfirmProgram.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmProgram.Location = new Point(20, 309);
            lblConfirmProgram.Name = "lblConfirmProgram";
            lblConfirmProgram.Size = new Size(69, 20);
            lblConfirmProgram.TabIndex = 2;
            lblConfirmProgram.Text = "Program:";
            // 
            // lblConfirmMembership
            // 
            lblConfirmMembership.AutoSize = true;
            lblConfirmMembership.BackColor = SystemColors.ButtonHighlight;
            lblConfirmMembership.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmMembership.Location = new Point(20, 263);
            lblConfirmMembership.Name = "lblConfirmMembership";
            lblConfirmMembership.Size = new Size(95, 20);
            lblConfirmMembership.TabIndex = 2;
            lblConfirmMembership.Text = "Membership:";
            // 
            // lblConfirmGender
            // 
            lblConfirmGender.AutoSize = true;
            lblConfirmGender.BackColor = SystemColors.ButtonHighlight;
            lblConfirmGender.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmGender.Location = new Point(20, 219);
            lblConfirmGender.Name = "lblConfirmGender";
            lblConfirmGender.Size = new Size(60, 20);
            lblConfirmGender.TabIndex = 2;
            lblConfirmGender.Text = "Gender:";
            // 
            // lblConfirmBirth
            // 
            lblConfirmBirth.AutoSize = true;
            lblConfirmBirth.BackColor = SystemColors.ButtonHighlight;
            lblConfirmBirth.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmBirth.Location = new Point(20, 175);
            lblConfirmBirth.Name = "lblConfirmBirth";
            lblConfirmBirth.Size = new Size(73, 20);
            lblConfirmBirth.TabIndex = 2;
            lblConfirmBirth.Text = "Birthdate:";
            // 
            // lblConfirmEmail
            // 
            lblConfirmEmail.AutoSize = true;
            lblConfirmEmail.BackColor = SystemColors.ButtonHighlight;
            lblConfirmEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmEmail.Location = new Point(20, 127);
            lblConfirmEmail.Name = "lblConfirmEmail";
            lblConfirmEmail.Size = new Size(49, 20);
            lblConfirmEmail.TabIndex = 2;
            lblConfirmEmail.Text = "Email:";
            // 
            // lblConfirmName
            // 
            lblConfirmName.AutoSize = true;
            lblConfirmName.BackColor = SystemColors.ButtonHighlight;
            lblConfirmName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmName.Location = new Point(20, 83);
            lblConfirmName.Name = "lblConfirmName";
            lblConfirmName.Size = new Size(79, 20);
            lblConfirmName.TabIndex = 2;
            lblConfirmName.Text = "Full Name:";
            // 
            // lblConfirmID
            // 
            lblConfirmID.AutoSize = true;
            lblConfirmID.BackColor = SystemColors.ButtonHighlight;
            lblConfirmID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmID.Location = new Point(20, 43);
            lblConfirmID.Name = "lblConfirmID";
            lblConfirmID.Size = new Size(27, 20);
            lblConfirmID.TabIndex = 2;
            lblConfirmID.Text = "ID:";
            // 
            // btnCancelAdd
            // 
            btnCancelAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelAdd.FlatStyle = FlatStyle.Flat;
            btnCancelAdd.Location = new Point(332, 400);
            btnCancelAdd.Name = "btnCancelAdd";
            btnCancelAdd.Size = new Size(94, 38);
            btnCancelAdd.TabIndex = 1;
            btnCancelAdd.Text = "CANCEL";
            btnCancelAdd.UseVisualStyleBackColor = true;
            btnCancelAdd.Click += btnCancelAdd_Click;
            // 
            // btnConfrimAdd
            // 
            btnConfrimAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfrimAdd.FlatStyle = FlatStyle.Flat;
            btnConfrimAdd.Location = new Point(233, 400);
            btnConfrimAdd.Name = "btnConfrimAdd";
            btnConfrimAdd.Size = new Size(93, 38);
            btnConfrimAdd.TabIndex = 1;
            btnConfrimAdd.Text = "CONFIRM";
            btnConfrimAdd.UseVisualStyleBackColor = true;
            btnConfrimAdd.Click += btnConfrimAdd_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            richTextBox2.Location = new Point(3, 3);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(426, 450);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 43);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 1;
            label8.Text = "ID:";
            // 
            // FormMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelConfirmation);
            Controls.Add(label5);
            Controls.Add(cbProgram);
            Controls.Add(btnRefresh);
            Controls.Add(cbMonthly);
            Controls.Add(cbAnnual);
            Controls.Add(richTextBox1);
            Controls.Add(dtpBirthdate);
            Controls.Add(rbNon);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(txtEmail);
            Controls.Add(gender);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(btnAddMember);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMembers";
            Text = "Members";
            Load += FormMembers_Load;
            panelConfirmation.ResumeLayout(false);
            panelConfirmation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddMember;
        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtID;
        private Label label4;
        private TextBox txtEmail;
        private Label label6;
        private DateTimePicker dtpBirthdate;
        private Label label7;
        private Label gender;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private RadioButton rbNon;
        private RichTextBox richTextBox1;
        private CheckBox cbAnnual;
        private CheckBox cbMonthly;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnRefresh;
        private ComboBox cbProgram;
        private Label label5;
        private Panel panelConfirmation;
        private Button btnCancelAdd;
        private Button btnConfrimAdd;
        private RichTextBox richTextBox2;
        private Label lblConfirmProgram;
        private Label lblConfirmMembership;
        private Label lblConfirmGender;
        private Label lblConfirmBirth;
        private Label lblConfirmEmail;
        private Label lblConfirmName;
        private Label lblConfirmID;
        private Label label8;
    }
}