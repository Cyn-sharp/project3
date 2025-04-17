namespace gymApp.Forms
{
    partial class FormSearchMember
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
            txtSearch = new TextBox();
            dgvSearchResult = new DataGridView();
            btnSearch = new Button();
            btnClose = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResult).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(730, 23);
            txtSearch.TabIndex = 0;
            // 
            // dgvSearchResult
            // 
            dgvSearchResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSearchResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchResult.Location = new Point(12, 41);
            dgvSearchResult.Name = "dgvSearchResult";
            dgvSearchResult.Size = new Size(730, 352);
            dgvSearchResult.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(560, 399);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 26);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(654, 399);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(88, 26);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 405);
            label4.Name = "label4";
            label4.Size = new Size(164, 16);
            label4.TabIndex = 3;
            label4.Text = "PLEASE SEARCH A MEMBER";
            // 
            // FormSearchMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 437);
            Controls.Add(label4);
            Controls.Add(btnClose);
            Controls.Add(btnSearch);
            Controls.Add(dgvSearchResult);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSearchMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSearchMember";
            Load += FormSearchMember_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSearchResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private DataGridView dgvSearchResult;
        private Button btnSearch;
        private Button btnClose;
        private Label label4;
    }
}