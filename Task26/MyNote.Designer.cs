namespace CsharpSolutions.Exercises.Task26
{
    partial class MyNote
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
            this.loadOld = new System.Windows.Forms.Button();
            this.saveData = new System.Windows.Forms.Button();
            this.createNew = new System.Windows.Forms.Button();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prio = new System.Windows.Forms.ComboBox();
            this.due = new System.Windows.Forms.DateTimePicker();
            this.remarks = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadOld
            // 
            this.loadOld.Location = new System.Drawing.Point(178, 18);
            this.loadOld.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadOld.Name = "loadOld";
            this.loadOld.Size = new System.Drawing.Size(152, 54);
            this.loadOld.TabIndex = 1;
            this.loadOld.Text = "Load file";
            this.loadOld.UseVisualStyleBackColor = true;
            this.loadOld.Click += new System.EventHandler(this.loadOld_Click);
            // 
            // saveData
            // 
            this.saveData.Location = new System.Drawing.Point(339, 18);
            this.saveData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(152, 54);
            this.saveData.TabIndex = 2;
            this.saveData.Text = "Save file";
            this.saveData.UseVisualStyleBackColor = true;
            this.saveData.Click += new System.EventHandler(this.saveData_Click);
            // 
            // createNew
            // 
            this.createNew.Location = new System.Drawing.Point(18, 18);
            this.createNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createNew.Name = "createNew";
            this.createNew.Size = new System.Drawing.Size(152, 54);
            this.createNew.TabIndex = 0;
            this.createNew.Text = "New file";
            this.createNew.UseVisualStyleBackColor = true;
            this.createNew.Click += new System.EventHandler(this.createNew_Click);
            // 
            // tableLayout
            // 
            this.tableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout.Controls.Add(this.label1, 0, 0);
            this.tableLayout.Controls.Add(this.label2, 0, 1);
            this.tableLayout.Controls.Add(this.label3, 0, 2);
            this.tableLayout.Controls.Add(this.label4, 0, 3);
            this.tableLayout.Controls.Add(this.label5, 0, 4);
            this.tableLayout.Controls.Add(this.prio, 1, 4);
            this.tableLayout.Controls.Add(this.due, 1, 3);
            this.tableLayout.Controls.Add(this.remarks, 1, 2);
            this.tableLayout.Controls.Add(this.description, 1, 1);
            this.tableLayout.Controls.Add(this.title, 1, 0);
            this.tableLayout.Location = new System.Drawing.Point(18, 82);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 5;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayout.Size = new System.Drawing.Size(660, 509);
            this.tableLayout.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Remarks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 355);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Due";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 432);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prio";
            // 
            // prio
            // 
            this.prio.Dock = System.Windows.Forms.DockStyle.Top;
            this.prio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prio.FormattingEnabled = true;
            this.prio.Location = new System.Drawing.Point(184, 437);
            this.prio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prio.Name = "prio";
            this.prio.Size = new System.Drawing.Size(472, 28);
            this.prio.TabIndex = 9;
            this.prio.SelectedIndexChanged += new System.EventHandler(this.prio_SelectedIndexChanged);
            // 
            // due
            // 
            this.due.Dock = System.Windows.Forms.DockStyle.Top;
            this.due.Location = new System.Drawing.Point(184, 360);
            this.due.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.due.Name = "due";
            this.due.Size = new System.Drawing.Size(472, 28);
            this.due.TabIndex = 7;
            this.due.ValueChanged += new System.EventHandler(this.due_ValueChanged);
            // 
            // remarks
            // 
            this.remarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remarks.Location = new System.Drawing.Point(184, 283);
            this.remarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remarks.Multiline = true;
            this.remarks.Name = "remarks";
            this.remarks.Size = new System.Drawing.Size(472, 67);
            this.remarks.TabIndex = 5;
            this.remarks.TextChanged += new System.EventHandler(this.remarks_TextChanged);
            // 
            // description
            // 
            this.description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.description.Location = new System.Drawing.Point(184, 82);
            this.description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(472, 191);
            this.description.TabIndex = 3;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(184, 5);
            this.title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(472, 28);
            this.title.TabIndex = 1;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Notes (*.xml)|*.xml";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Notes (*.xml)|*.xml";
            // 
            // MyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 609);
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.saveData);
            this.Controls.Add(this.createNew);
            this.Controls.Add(this.loadOld);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MyNote";
            this.Text = "MyNote";
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadOld;
        private System.Windows.Forms.Button saveData;
        private System.Windows.Forms.Button createNew;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox prio;
        private System.Windows.Forms.DateTimePicker due;
        private System.Windows.Forms.TextBox remarks;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}