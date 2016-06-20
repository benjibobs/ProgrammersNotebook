using System;
using System.Windows.Forms;
using System.IO;

namespace ProgrammersNotebook
{
    public partial class NewOrOpenForm : Form
    {
        public NewOrOpenForm()
        {
            InitializeComponent();
        }

        public bool done = false;

        private void openLibBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openLibPrompt.ShowDialog();
            if (result == DialogResult.OK && openLibPrompt.SelectedPath.EndsWith(".qvlibrary"))
            {
                Main main = (Main)this.Owner;
                main.libPath = openLibPrompt.SelectedPath;
                done = true;
                this.Close();
            }
            else if (result == DialogResult.OK)
            {
                MessageBox.Show("Folder selected is not a Quiver Library", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("An error occured selecting this folder (" + result.ToString() + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewLibBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = newLibPrompt.ShowDialog();
            if (result == DialogResult.OK)
            {
                Util.createNewLibrary(newLibPrompt.FileName, Path.GetDirectoryName(newLibPrompt.FileName));
                Main main = (Main)this.Owner;
                main.libPath = Path.GetDirectoryName(newLibPrompt.FileName);
                done = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("An error occured selecting this folder (" + result.ToString() + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewOrOpenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
