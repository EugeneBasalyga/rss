namespace lab4spp
{
    partial class EmailsForm
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
            this.listViewEmails = new System.Windows.Forms.ListView();
            this.NamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewEmails
            // 
            this.listViewEmails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NamecolumnHeader});
            this.listViewEmails.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewEmails.FullRowSelect = true;
            this.listViewEmails.GridLines = true;
            this.listViewEmails.Location = new System.Drawing.Point(0, 0);
            this.listViewEmails.MultiSelect = false;
            this.listViewEmails.Name = "listViewEmails";
            this.listViewEmails.Size = new System.Drawing.Size(305, 125);
            this.listViewEmails.TabIndex = 1;
            this.listViewEmails.UseCompatibleStateImageBehavior = false;
            this.listViewEmails.View = System.Windows.Forms.View.Details;
            // 
            // NamecolumnHeader
            // 
            this.NamecolumnHeader.Text = "Email";
            this.NamecolumnHeader.Width = 298;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(5, 132);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(120, 21);
            this.textBoxEmail.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(138, 132);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(219, 132);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // EmailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 167);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.listViewEmails);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "EmailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailsForm";
            this.Load += new System.EventHandler(this.EmailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEmails;
        private System.Windows.Forms.ColumnHeader NamecolumnHeader;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonOk;
    }
}