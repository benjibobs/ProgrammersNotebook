namespace QuiverPortUnoff
{
    partial class NewOrOpenForm
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
            this.openLibBtn = new System.Windows.Forms.Button();
            this.NewLibBtn = new System.Windows.Forms.Button();
            this.openLibPrompt = new System.Windows.Forms.FolderBrowserDialog();
            this.newLibPrompt = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // openLibBtn
            // 
            this.openLibBtn.Location = new System.Drawing.Point(12, 12);
            this.openLibBtn.Name = "openLibBtn";
            this.openLibBtn.Size = new System.Drawing.Size(205, 62);
            this.openLibBtn.TabIndex = 0;
            this.openLibBtn.Text = "Open Quiver Library";
            this.openLibBtn.UseVisualStyleBackColor = true;
            this.openLibBtn.Click += new System.EventHandler(this.openLibBtn_Click);
            // 
            // NewLibBtn
            // 
            this.NewLibBtn.Location = new System.Drawing.Point(223, 12);
            this.NewLibBtn.Name = "NewLibBtn";
            this.NewLibBtn.Size = new System.Drawing.Size(209, 62);
            this.NewLibBtn.TabIndex = 1;
            this.NewLibBtn.Text = "Create New Quiver Library";
            this.NewLibBtn.UseVisualStyleBackColor = true;
            this.NewLibBtn.Click += new System.EventHandler(this.NewLibBtn_Click);
            // 
            // openLibPrompt
            // 
            this.openLibPrompt.ShowNewFolderButton = false;
            // 
            // NewOrOpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 88);
            this.Controls.Add(this.NewLibBtn);
            this.Controls.Add(this.openLibBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewOrOpenForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openLibBtn;
        private System.Windows.Forms.Button NewLibBtn;
        private System.Windows.Forms.FolderBrowserDialog openLibPrompt;
        private System.Windows.Forms.FolderBrowserDialog newLibPrompt;
    }
}