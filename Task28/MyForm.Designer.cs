namespace CsharpSolutions.Exercises.Task28
{
    partial class MyForm
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
            this.myControl1 = new CsharpSolutions.Exercises.Task28.MyControl();
            this.SuspendLayout();
            // 
            // myControl1
            // 
            this.myControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myControl1.Location = new System.Drawing.Point(12, 12);
            this.myControl1.Name = "myControl1";
            this.myControl1.Seconds = 5;
            this.myControl1.Size = new System.Drawing.Size(260, 237);
            this.myControl1.TabIndex = 0;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.myControl1);
            this.Name = "MyForm";
            this.Text = "MyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MyControl myControl1;
    }
}