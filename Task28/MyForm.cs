using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CsharpSolutions.Exercises.Task28
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
            myControl1.Updated += new EventHandler<UpdateEventArgs>(myControl1_Updated);
        }

        void myControl1_Updated(object sender, UpdateEventArgs e)
        {
            Text = "remaining: " + e.CurrentTime;
        }
    }
}
