namespace lab4spp
{
    partial class FilterForm
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
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxDescryption = new System.Windows.Forms.RichTextBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.emailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Location = new System.Drawing.Point(79, 56);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(320, 21);
            this.comboBoxTitle.TabIndex = 8;
            this.comboBoxTitle.SelectedIndexChanged += new System.EventHandler(this.comboBoxTitle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title :";
            // 
            // richTextBoxDescryption
            // 
            this.richTextBoxDescryption.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxDescryption.Location = new System.Drawing.Point(22, 92);
            this.richTextBoxDescryption.Name = "richTextBoxDescryption";
            this.richTextBoxDescryption.ReadOnly = true;
            this.richTextBoxDescryption.Size = new System.Drawing.Size(377, 119);
            this.richTextBoxDescryption.TabIndex = 6;
            this.richTextBoxDescryption.Text = "";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(19, 220);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(0, 13);
            this.linkLabel.TabIndex = 9;
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(79, 28);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(120, 20);
            this.textBoxFind.TabIndex = 10;
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(19, 35);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(27, 13);
            this.labelFind.TabIndex = 11;
            this.labelFind.Text = "Find";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(205, 28);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(59, 22);
            this.buttonGo.TabIndex = 12;
            this.buttonGo.Text = "Go!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailsToolStripMenuItem,
            this.sendEmailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // emailsToolStripMenuItem
            // 
            this.emailsToolStripMenuItem.Name = "emailsToolStripMenuItem";
            this.emailsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.emailsToolStripMenuItem.Text = "Emails";
            this.emailsToolStripMenuItem.Click += new System.EventHandler(this.emailsToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 242);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.comboBoxTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxDescryption);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterForm";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxDescryption;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem emailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
    }
}