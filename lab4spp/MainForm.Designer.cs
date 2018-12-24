namespace lab4spp
{
    partial class MainForm
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
            this.Readbutton = new System.Windows.Forms.Button();
            this.RSSurltextBox = new System.Windows.Forms.TextBox();
            this.RSSurllabel = new System.Windows.Forms.Label();
            this.richTextBoxDescryption = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Readbutton
            // 
            this.Readbutton.Location = new System.Drawing.Point(305, 33);
            this.Readbutton.Name = "Readbutton";
            this.Readbutton.Size = new System.Drawing.Size(87, 27);
            this.Readbutton.TabIndex = 0;
            this.Readbutton.Text = "Read";
            this.Readbutton.UseVisualStyleBackColor = true;
            this.Readbutton.Click += new System.EventHandler(this.Readbutton_Click);
            // 
            // RSSurltextBox
            // 
            this.RSSurltextBox.Location = new System.Drawing.Point(72, 36);
            this.RSSurltextBox.Name = "RSSurltextBox";
            this.RSSurltextBox.Size = new System.Drawing.Size(216, 22);
            this.RSSurltextBox.TabIndex = 1;
            this.RSSurltextBox.Text = "https://www.sport-express.ru/services/materials/news/football/se/";
            // 
            // RSSurllabel
            // 
            this.RSSurllabel.AutoSize = true;
            this.RSSurllabel.Location = new System.Drawing.Point(12, 39);
            this.RSSurllabel.Name = "RSSurllabel";
            this.RSSurllabel.Size = new System.Drawing.Size(54, 15);
            this.RSSurllabel.TabIndex = 2;
            this.RSSurllabel.Text = "RSS Url :";
            // 
            // richTextBoxDescryption
            // 
            this.richTextBoxDescryption.Location = new System.Drawing.Point(15, 108);
            this.richTextBoxDescryption.Name = "richTextBoxDescryption";
            this.richTextBoxDescryption.ReadOnly = true;
            this.richTextBoxDescryption.Size = new System.Drawing.Size(377, 119);
            this.richTextBoxDescryption.TabIndex = 3;
            this.richTextBoxDescryption.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title :";
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Location = new System.Drawing.Point(72, 68);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(320, 23);
            this.comboBoxTitle.TabIndex = 5;
            this.comboBoxTitle.SelectedIndexChanged += new System.EventHandler(this.comboBoxTitle_SelectedIndexChanged);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(12, 232);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(0, 15);
            this.linkLabel.TabIndex = 6;
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 256);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.comboBoxTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxDescryption);
            this.Controls.Add(this.RSSurllabel);
            this.Controls.Add(this.RSSurltextBox);
            this.Controls.Add(this.Readbutton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS Reader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Readbutton;
        private System.Windows.Forms.TextBox RSSurltextBox;
        private System.Windows.Forms.Label RSSurllabel;
        private System.Windows.Forms.RichTextBox richTextBoxDescryption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
    }
}

