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
            btnEdit = new Button();
            btnSearchMember = new Button();
            button1 = new Button();
            button2 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnSoonToExpire = new Button();
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
            dataGridView1.Size = new Size(641, 380);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += DgvMemberships_CellFormatting;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(183, 9);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 1;
            label4.Text = "Memberships List";
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(218, 427);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(200, 39);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "EDIT MEMBER";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSearchMember
            // 
            btnSearchMember.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearchMember.FlatStyle = FlatStyle.Flat;
            btnSearchMember.Location = new Point(424, 427);
            btnSearchMember.Name = "btnSearchMember";
            btnSearchMember.Size = new Size(200, 39);
            btnSearchMember.TabIndex = 3;
            btnSearchMember.Text = "SEARCH MEMBER";
            btnSearchMember.UseVisualStyleBackColor = true;
            btnSearchMember.Click += btnSearchMember_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(630, 425);
            button1.Name = "button1";
            button1.Size = new Size(200, 39);
            button1.TabIndex = 4;
            button1.Text = "REMOVE MEMBER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDelete_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(12, 427);
            button2.Name = "button2";
            button2.Size = new Size(200, 39);
            button2.TabIndex = 5;
            button2.Text = "ACTIVATE MEMBER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnActivate_Click;
            // 
            // btnSoonToExpire
            // 
            btnSoonToExpire.FlatStyle = FlatStyle.Flat;
            btnSoonToExpire.Location = new Point(12, 39);
            btnSoonToExpire.Name = "btnSoonToExpire";
            btnSoonToExpire.Size = new Size(165, 38);
            btnSoonToExpire.TabIndex = 3;
            btnSoonToExpire.Text = "View Soon To Expire";
            btnSoonToExpire.UseVisualStyleBackColor = true;
            btnSoonToExpire.Click += btnSoontoExpire_Click;
            // 
            // formMemberships
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 478);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSearchMember);
            Controls.Add(btnSoonToExpire);
            Controls.Add(btnEdit);
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
        private Button btnEdit;
        private Button btnSearchMember;
        private Button button1;
        private Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnSoonToExpire;
    }
}