using System;

namespace CsharpSolutions.Exercises.Task26
{
    //Don't forget to make this public!
    public class Note
    {
        public Note()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
            Due = DateTime.Today;
            Title = String.Empty;
            Remarks = String.Empty;
            Description = String.Empty;
            Priority = Prio.None;
        }

        public DateTime Created
        {
            get;
            set;
        }

        public DateTime Updated
        {
            get;
            set;
        }

        public DateTime Due
        {
            get;
            set;
        }

        public String Title
        {
            get;
            set;
        }

        public String Description
        {
            get;
            set;
        }

        public String Remarks
        {
            get;
            set;
        }

        public Prio Priority
        {
            get;
            set;
        }
    }
}
