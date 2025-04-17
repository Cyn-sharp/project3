namespace gymApp.Forms
{
    partial class formMemberships
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
            dataGridView1 = new DataGridView();
            label4 = new Label();
            btnRemind = new Button();
            btnSoontoExpire = new Button();
            btnRenew = new Button();
            btnShowStats = new Button();
            btnEdit = new Button();
            btnSearchMember = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(183, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(605, 363);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += DgvMemberships_CellFormatting;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(271, 11);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 1;
            label4.Text = "Memberships List";
            // 
            // btnRemind
            // 
            btnRemind.FlatStyle = FlatStyle.Flat;
            btnRemind.Location = new Point(12, 165);
            btnRemind.Name = "btnRemind";
            btnRemind.Size = new Size(165, 36);
            btnRemind.TabIndex = 2;
            btnRemind.Text = "REMIND";
            btnRemind.UseVisualStyleBackColor = true;
            btnRemind.Click += btnSendReminders_Click;
            // 
            // btnSoontoExpire
            // 
            btnSoontoExpire.FlatStyle = FlatStyle.Flat;
            btnSoontoExpire.Location = new Point(12, 123);
            btnSoontoExpire.Name = "btnSoontoExpire";
            btnSoontoExpire.Size = new Size(165, 36);
            btnSoontoExpire.TabIndex = 2;
            btnSoontoExpire.Text = "View Soon to Expire";
            btnSoontoExpire.UseVisualStyleBackColor = true;
            btnSoontoExpire.Click += btnSoontoExpire_Click;
            // 
            // btnRenew
            // 
            btnRenew.FlatStyle = FlatStyle.Flat;
            btnRenew.Location = new Point(12, 81);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(165, 36);
            btnRenew.TabIndex = 2;
            btnRenew.Text = "RENEW";
            btnRenew.UseVisualStyleBackColor = true;
            btnRenew.Click += btnRenew_Click;
            // 
            // btnShowStats
            // 
            btnShowStats.FlatStyle = FlatStyle.Flat;
            btnShowStats.Location = new Point(12, 39);
            btnShowStats.Name = "btnShowStats";
            btnShowStats.Size = new Size(165, 36);
            btnShowStats.TabIndex = 2;
            btnShowStats.Text = "SHOW STATS";
            btnShowStats.UseVisualStyleBackColor = true;
            btnShowStats.Click += btnShowStats_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(654, 408);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(134, 38);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "EDIT MEMBER";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSearchMember
            // 
            btnSearchMember.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearchMember.FlatStyle = FlatStyle.Flat;
            btnSearchMember.Location = new Point(506, 408);
            btnSearchMember.Name = "btnSearchMember";
            btnSearchMember.Size = new Size(142, 38);
            btnSearchMember.TabIndex = 3;
            btnSearchMember.Text = "SEARCH MEMBER";
            btnSearchMember.UseVisualStyleBackColor = true;
            btnSearchMember.Click += btnSearchMember_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(365, 408);
            button1.Name = "button1";
            button1.Size = new Size(135, 38);
            button1.TabIndex = 4;
            button1.Text = "REMOVE MEMBER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDelete_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(221, 408);
            button2.Name = "button2";
            button2.Size = new Size(138, 38);
            button2.TabIndex = 5;
            button2.Text = "ACTIVATE MEMBER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnActivate_Click;
            // 
            // formMemberships
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSearchMember);
            Controls.Add(btnEdit);
            Controls.Add(btnShowStats);
            Controls.Add(btnRenew);
            Controls.Add(btnSoontoExpire);
            Controls.Add(btnRemind);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formMemberships";
            Text = "Memberships";
            WindowState = FormWindowState.Maximized;
            Load += Memberships_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label4;
        private Button btnRemind;
        private Button btnSoontoExpire;
        private Button btnRenew;
        private Button btnShowStats;
        private Button btnEdit;
        private Button btnSearchMember;
        private Button button1;
        private Button button2;
    }
}