namespace gymApp.Forms
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(2, 65);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(786, 216);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(2, 24);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 1;
            label4.Text = "About App";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(624, 353);
            label6.Name = "label6";
            label6.Size = new Size(164, 25);
            label6.TabIndex = 2;
            label6.Text = "All rights reserved";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 381);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Name = "FormAbout";
            Text = "About";
            Load += FormAbout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label4;
        private Label label6;
    }
}