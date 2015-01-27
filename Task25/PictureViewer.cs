using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CsharpSolutions.Exercises.Task25
{
    public partial class PictureViewer : Form
    {
        //Store all used extensions
        String[] extensions;

        public PictureViewer()
        {
            //Add the extensions we want to use
            extensions = new[] { ".png", ".bmp", ".jpg", ".jpeg", ".gif" };
            InitializeComponent();
        }

        private void folderSelection_Click(object sender, EventArgs e)
        {
            //If the user accepted the folder browser dialog
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                //we just remove the current image
                photo.Image = null;
                //we clear the current available selection
                selection.Items.Clear();
                //store the directory
                var directory = new DirectoryInfo(folderBrowser.SelectedPath);
                //read out all files
                var files = directory.GetFiles();

                //add files to the range which fulfill the given condition
                selection.Items.AddRange(files.Where(file => extensions.Contains(file.Extension)).ToArray());
                selection.Enabled = selection.Items.Count > 0;

                if (selection.Enabled)
                    selection.SelectedIndex = 0;
            }
        }

        private void selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //And read the photo
            var file = (FileInfo)selection.SelectedItem;
            //From the given file name
            photo.Image = Image.FromFile(file.FullName);
        }
    }
}
