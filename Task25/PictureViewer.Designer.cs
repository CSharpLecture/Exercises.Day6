namespace CsharpSolutions.Exercises.Task25
{
    partial class PictureViewer
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
            this.folderSelection = new System.Windows.Forms.Button();
            this.selection = new System.Windows.Forms.ComboBox();
            this.photo = new System.Windows.Forms.PictureBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // folderSelection
            // 
            this.folderSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.folderSelection.Location = new System.Drawing.Point(0, 0);
            this.folderSelection.Name = "folderSelection";
            this.folderSelection.Size = new System.Drawing.Size(284, 36);
            this.folderSelection.TabIndex = 0;
            this.folderSelection.Text = "Open Folder";
            this.folderSelection.UseVisualStyleBackColor = true;
            this.folderSelection.Click += new System.EventHandler(this.folderSelection_Click);
            // 
            // selection
            // 
            this.selection.Dock = System.Windows.Forms.DockStyle.Top;
            this.selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selection.Enabled = false;
            this.selection.FormattingEnabled = true;
            this.selection.Location = new System.Drawing.Point(0, 36);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(284, 21);
            this.selection.TabIndex = 1;
            this.selection.SelectedIndexChanged += new System.EventHandler(this.selection_SelectedIndexChanged);
            // 
            // photo
            // 
            this.photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photo.Location = new System.Drawing.Point(0, 57);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(284, 205);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo.TabIndex = 2;
            this.photo.TabStop = false;
            // 
            // PictureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.selection);
            this.Controls.Add(this.folderSelection);
            this.Name = "PictureViewer";
            this.Text = "PictureViewer";
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button folderSelection;
        private System.Windows.Forms.ComboBox selection;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}