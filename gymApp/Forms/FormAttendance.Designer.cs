namespace gymApp.Forms
{
    partial class FormAttendance
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
            cmbMembers = new ComboBox();
            dtpDate = new DateTimePicker();
            btnCheckIn = new Button();
            btnCheckOut = new Button();
            dgvAttendance = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // cmbMembers
            // 
            cmbMembers.FormattingEnabled = true;
            cmbMembers.Location = new Point(12, 12);
            cmbMembers.Name = "cmbMembers";
            cmbMembers.Size = new Size(262, 23);
            cmbMembers.TabIndex = 0;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(12, 41);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(262, 23);
            dtpDate.TabIndex = 1;
            // 
            // btnCheckIn
            // 
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Location = new Point(149, 70);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(125, 52);
            btnCheckIn.TabIndex = 2;
            btnCheckIn.Text = "CHECK IN";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Location = new Point(12, 70);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(131, 52);
            btnCheckOut.TabIndex = 2;
            btnCheckOut.Text = "CHECK OUT";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // dgvAttendance
            // 
            dgvAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(280, 12);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.Size = new Size(396, 454);
            dgvAttendance.TabIndex = 3;
            // 
            // FormAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 478);
            Controls.Add(dgvAttendance);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(dtpDate);
            Controls.Add(cmbMembers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAttendance";
            Text = "Member's Attendance";
            Load += FormAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbMembers;
        private DateTimePicker dtpDate;
        private Button btnCheckIn;
        private Button btnCheckOut;
        private DataGridView dgvAttendance;
    }
}