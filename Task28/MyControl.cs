using System;
using System.Windows.Forms;

namespace CsharpSolutions.Exercises.Task28
{
    public partial class MyControl : UserControl
    {
        //Just place two fields for the remaining seconds and the seconds from the beginning
        int seconds;
        int remaining;
        string reason;

        //Here are our events
        public event EventHandler Started;
        public event EventHandler<StoppedEventArgs> Stopped;
        public event EventHandler<UpdateEventArgs> Updated;

        public MyControl()
        {
            InitializeComponent();
            //Set both with their property-setters
            Seconds = 5;
            Remaining = seconds;
        }

        //This is a read-only property
        public int Remaining
        {
            get { return remaining; }
            private set
            {
                remaining = value;

                if (timer.Enabled)
                {
                    label.Text = String.Format("{0}s", remaining.ToString());

                    //Trigger our updated event
                    if (Updated != null)
                        Updated(this, new UpdateEventArgs { CurrentTime = remaining });

                    if (remaining == 0)
                    {
                        button.Text = "Reset";
                        timer.Stop();

                        //Trigger our stopped event
                        if (Stopped != null)
                            Stopped(this, new StoppedEventArgs { PassedTime = seconds, Reason = reason });
                    }
                }
            }
        }

        //This one could be also modified
        public int Seconds
        {
            get { return seconds; }
            set
            {
                seconds = Math.Max(0, value);

                //Only if currently no timer is running
                if (!timer.Enabled)
                {
                    //Set the button text once the value is modified
                    button.Text = String.Format("Start ({0}ms)", Seconds);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            //If no timer is running
            if (!timer.Enabled)
            {
                //and if there is nothing remaining
                if (Remaining == 0)
                {
                    //then reset everything
                    Remaining = seconds;
                    Seconds = seconds;
                }
                else
                {
                    //Otherwise start the countdown
                    reason = "Timeout";
                    button.Text = "Stop";
                    timer.Start();
                    Remaining = seconds;

                    //Trigger our started event
                    if (Started != null)
                        Started(this, EventArgs.Empty);
                }
            }
            else //or just stop everything
            {
                reason = "Aborted";
                Remaining = 0;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Decrement (i.e. countdown)
            Remaining--;
        }
    }
}
