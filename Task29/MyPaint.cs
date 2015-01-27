using System;
using System.Drawing;
using System.Windows.Forms;

namespace CsharpSolutions.Exercises.Task29
{
    public partial class MyPaint : Form
    {
        //We need to track if 
        bool down; //the mouse is pressed
        Point previous; //what the previous point was
        Bitmap image; //what the current image we are drawing on is

        public MyPaint()
        {
            InitializeComponent();
            //set default values
            selectColor.BackColor = Color.Red;
            penwidth.Value = 1m;
            //reset the image
            reset_Click(this, EventArgs.Empty);
        }

        private void selectColor_Click(object sender, EventArgs e)
        {
            //change the color with the dialog
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                selectColor.BackColor = colorDialog.Color;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            //initialize a new bitmap and set it to the canvas
            image = new Bitmap(2000, 2000);
            canvas.Image = image;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            //the previous location is the current one
            previous = e.Location;
            down = true;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            //we are not down any more
            down = false;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            //if we are down
            if (down)
            {
                //we want to draw on the canvas
                var width = (float)penwidth.Value;
                var color = selectColor.BackColor;

                //Graphics can be disposed - so we should dispose it
                using (var g = Graphics.FromImage(image))
                    g.DrawLine(new Pen(color, width), previous, e.Location);

                previous = e.Location;
                canvas.Refresh();
            }
        }
    }
}
