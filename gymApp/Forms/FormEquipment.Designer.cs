namespace gymApp.Forms
{
    partial class FormEquipment
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
            rdoNotAvailable = new RadioButton();
            rdoAvailable = new RadioButton();
            label6 = new Label();
            label4 = new Label();
            txtEquipmentName = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            rdoUnderM = new RadioButton();
            btnClearSearch = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // rdoNotAvailable
            // 
            rdoNotAvailable.AutoSize = true;
            rdoNotAvailable.Location = new Point(45, 294);
            rdoNotAvailable.Name = "rdoNotAvailable";
            rdoNotAvailable.Size = new Size(96, 19);
            rdoNotAvailable.TabIndex = 20;
            rdoNotAvailable.TabStop = true;
            rdoNotAvailable.Text = "Not Available";
            rdoNotAvailable.UseVisualStyleBackColor = true;
            // 
            // rdoAvailable
            // 
            rdoAvailable.AutoSize = true;
            rdoAvailable.Location = new Point(45, 269);
            rdoAvailable.Name = "rdoAvailable";
            rdoAvailable.Size = new Size(73, 19);
            rdoAvailable.TabIndex = 19;
            rdoAvailable.TabStop = true;
            rdoAvailable.Text = "Available";
            rdoAvailable.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(357, 11);
            label6.Name = "label6";
            label6.Size = new Size(141, 28);
            label6.TabIndex = 14;
            label6.Text = "Equipment List";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(26, 238);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 12;
            label4.Text = "Availability";
            // 
            // txtEquipmentName
            // 
            txtEquipmentName.Location = new Point(135, 163);
            txtEquipmentName.Name = "txtEquipmentName";
            txtEquipmentName.Size = new Size(122, 23);
            txtEquipmentName.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 169);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 11;
            label2.Text = "Equipment Name:";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(357, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(427, 337);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dgvEquipment_CellClick;
            dataGridView1.RowPrePaint += dgvEquipment_RowPrePaint;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(379, 393);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 47);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(519, 393);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(119, 47);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Location = new Point(665, 393);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(119, 47);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "DELETE";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // rdoUnderM
            // 
            rdoUnderM.AutoSize = true;
            rdoUnderM.Location = new Point(45, 319);
            rdoUnderM.Name = "rdoUnderM";
            rdoUnderM.Size = new Size(129, 19);
            rdoUnderM.TabIndex = 20;
            rdoUnderM.TabStop = true;
            rdoUnderM.Text = "Under Maintenance";
            rdoUnderM.UseVisualStyleBackColor = true;
            // 
            // btnClearSearch
            // 
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Location = new Point(276, 79);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(75, 32);
            btnClearSearch.TabIndex = 23;
            btnClearSearch.Text = "Clear";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(195, 79);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 32);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.Location = new Point(21, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "'Enter equipment name'";
            txtSearch.Size = new Size(330, 23);
            txtSearch.TabIndex = 21;
            // 
            // btnRefresh
            // 
            btnRefresh.AllowDrop = true;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(26, 359);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(67, 28);
            btnRefresh.TabIndex = 24;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormEquipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnClearSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(rdoUnderM);
            Controls.Add(rdoNotAvailable);
            Controls.Add(rdoAvailable);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtEquipmentName);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEquipment";
            Text = "Equipment";
            Load += FormEquipment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rdoNotAvailable;
        private RadioButton rdoAvailable;
        private Label label6;
        private Label label4;
        private TextBox txtEquipmentName;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRemove;
        private RadioButton rdoUnderM;
        private Button btnClearSearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnRefresh;
    }
}