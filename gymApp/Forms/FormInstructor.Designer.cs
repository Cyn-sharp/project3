namespace gymApp.Forms
{
    partial class FormInstructor
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
            components = new System.ComponentModel.Container();
            btnRemove = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvInstructors = new DataGridView();
            label2 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            label4 = new Label();
            label6 = new Label();
            bindingSource1 = new BindingSource(components);
            cboSpecialization = new ComboBox();
            label7 = new Label();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClearSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInstructors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Location = new Point(669, 391);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(119, 47);
            btnRemove.TabIndex = 0;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(523, 391);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(119, 47);
            btnEdit.TabIndex = 0;
            btnEdit.Text = " EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(361, 391);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 47);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvInstructors
            // 
            dgvInstructors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInstructors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInstructors.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInstructors.Location = new Point(361, 48);
            dgvInstructors.Name = "dgvInstructors";
            dgvInstructors.Size = new Size(427, 337);
            dgvInstructors.TabIndex = 1;
            dgvInstructors.CellClick += dgvInstructors_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 148);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(113, 140);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(132, 23);
            txtFirstName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 177);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(112, 169);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(132, 23);
            txtLastName.TabIndex = 3;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(46, 260);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(51, 19);
            rdoMale.TabIndex = 4;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(46, 285);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(63, 19);
            rdoFemale.TabIndex = 4;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(27, 229);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 2;
            label4.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(361, 9);
            label6.Name = "label6";
            label6.Size = new Size(143, 28);
            label6.TabIndex = 2;
            label6.Text = "Instructor's List";
            // 
            // bindingSource1
            // 
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // cboSpecialization
            // 
            cboSpecialization.FormattingEnabled = true;
            cboSpecialization.Items.AddRange(new object[] { "Weight Loss specialists", "Strength Trainee", "Health Coach", "Yoga", "Fitness Trainer", "Wellness Specialist" });
            cboSpecialization.Location = new Point(113, 202);
            cboSpecialization.Name = "cboSpecialization";
            cboSpecialization.Size = new Size(132, 23);
            cboSpecialization.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 210);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 2;
            label7.Text = "Specialization:";
            // 
            // btnRefresh
            // 
            btnRefresh.AllowDrop = true;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(29, 320);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(67, 28);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.Location = new Point(25, 48);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "'Enter instructor name'";
            txtSearch.Size = new Size(330, 23);
            txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(199, 77);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 32);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClearSearch
            // 
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Location = new Point(280, 77);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(75, 32);
            btnClearSearch.TabIndex = 11;
            btnClearSearch.Text = "Clear";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // FormInstructor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(cboSpecialization);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(txtLastName);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(dgvInstructors);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInstructor";
            Text = "Instructor";
            Load += FormInstructor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInstructors).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemove;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvInstructors;
        private Label label2;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtLastName;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private Label label4;
        private Label label6;
        private BindingSource bindingSource1;
        private ComboBox cboSpecialization;
        private Label label7;
        private Button btnRefresh;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClearSearch;
    }
}