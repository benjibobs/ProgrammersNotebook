namespace ProgrammersNotebook
{
    partial class Main
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
            this.library = new System.Windows.Forms.FlowLayoutPanel();
            this.noteList = new System.Windows.Forms.FlowLayoutPanel();
            this.note = new System.Windows.Forms.FlowLayoutPanel();
            this.openQuiver = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // library
            // 
            this.library.BackColor = System.Drawing.Color.White;
            this.library.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.library.Dock = System.Windows.Forms.DockStyle.Left;
            this.library.Location = new System.Drawing.Point(0, 0);
            this.library.Name = "library";
            this.library.Size = new System.Drawing.Size(200, 961);
            this.library.TabIndex = 0;
            // 
            // noteList
            // 
            this.noteList.BackColor = System.Drawing.Color.White;
            this.noteList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noteList.Dock = System.Windows.Forms.DockStyle.Left;
            this.noteList.Location = new System.Drawing.Point(200, 0);
            this.noteList.Name = "noteList";
            this.noteList.Size = new System.Drawing.Size(200, 961);
            this.noteList.TabIndex = 1;
            // 
            // note
            // 
            this.note.BackColor = System.Drawing.Color.White;
            this.note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.note.Dock = System.Windows.Forms.DockStyle.Left;
            this.note.Location = new System.Drawing.Point(400, 0);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(200, 961);
            this.note.TabIndex = 2;
            // 
            // openQuiver
            // 
            this.openQuiver.Description = "Please select your .qvlibrary folder";
            this.openQuiver.ShowNewFolderButton = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.note);
            this.Controls.Add(this.noteList);
            this.Controls.Add(this.library);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notedown";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel library;
        private System.Windows.Forms.FlowLayoutPanel noteList;
        private System.Windows.Forms.FlowLayoutPanel note;
        private System.Windows.Forms.FolderBrowserDialog openQuiver;
    }
}

