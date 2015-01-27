using System;

namespace CsharpSolutions.Exercises.Task28
{
    public class StoppedEventArgs : EventArgs
    {
        public int PassedTime { get; set; }

        public string Reason { get; set; }
    }
}
