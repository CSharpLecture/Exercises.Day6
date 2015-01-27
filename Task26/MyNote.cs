using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CsharpSolutions.Exercises.Task26
{
    public partial class MyNote : Form
    {
        //saving the current note
        Note current;

        public MyNote()
        {
            InitializeComponent();
            //Read out all possible enum values and storing them in the combobox
            var values = Enum.GetValues(typeof(Prio));

            foreach (var value in values)
                prio.Items.Add(value);

            //Start with a fresh one
            SetUi(new Note());
        }

        private void createNew_Click(object sender, EventArgs e)
        {
            //see above
            SetUi(new Note());
        }

        private void loadOld_Click(object sender, EventArgs e)
        {
            //if the user agrees on the open file dialog
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //we start deserializing
                var xml = new XmlSerializer(typeof(Note));

                using (var fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    var note = xml.Deserialize(fs) as Note;
                    SetUi(note);
                }
            }
        }

        private void saveData_Click(object sender, EventArgs e)
        {
            //if save file is OK
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //we open the serializer
                var xml = new XmlSerializer(typeof(Note));

                using (var fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    //update the updated propety
                    current.Updated = DateTime.Now;
                    xml.Serialize(fs, current);
                }
            }
        }

        //Just copy all values to the user controls
        void SetUi(Note note)
        {
            current = note;
            title.Text = note.Title;
            description.Text = note.Description;
            due.Value = note.Due;
            prio.SelectedItem = note.Priority;
            remarks.Text = note.Remarks;
        }

        //those handlers just keep the values updated
        private void title_TextChanged(object sender, EventArgs e)
        {
            current.Title = title.Text;
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            current.Description = description.Text;
        }

        private void remarks_TextChanged(object sender, EventArgs e)
        {
            current.Remarks = remarks.Text;
        }

        private void due_ValueChanged(object sender, EventArgs e)
        {
            current.Due = due.Value;
        }

        private void prio_SelectedIndexChanged(object sender, EventArgs e)
        {
            current.Priority = (Prio)prio.SelectedItem;
        }
    }
}
