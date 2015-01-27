namespace CsharpSolutions.Exercises.Task29
{
    partial class MyPaint
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.selectColor = new System.Windows.Forms.Button();
            this.penwidth = new System.Windows.Forms.NumericUpDown();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.penwidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // selectColor
            // 
            this.selectColor.BackColor = System.Drawing.Color.Black;
            this.selectColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectColor.Location = new System.Drawing.Point(0, 0);
            this.selectColor.Name = "selectColor";
            this.selectColor.Size = new System.Drawing.Size(420, 31);
            this.selectColor.TabIndex = 0;
            this.selectColor.UseVisualStyleBackColor = false;
            this.selectColor.Click += new System.EventHandler(this.selectColor_Click);
            // 
            // penwidth
            // 
            this.penwidth.Dock = System.Windows.Forms.DockStyle.Top;
            this.penwidth.Location = new System.Drawing.Point(0, 31);
            this.penwidth.Name = "penwidth";
            this.penwidth.Size = new System.Drawing.Size(420, 20);
            this.penwidth.TabIndex = 1;
            // 
            // canvas
            // 
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 51);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(420, 279);
            this.canvas.TabIndex = 2;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // reset
            // 
            this.reset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reset.Location = new System.Drawing.Point(0, 330);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(420, 34);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // MyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 364);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.penwidth);
            this.Controls.Add(this.selectColor);
            this.Name = "MyPaint";
            this.Text = "MyPaint";
            ((System.ComponentModel.ISupportInitialize)(this.penwidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button selectColor;
        private System.Windows.Forms.NumericUpDown penwidth;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button reset;
    }
}