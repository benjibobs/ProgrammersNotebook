using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuiverPortUnoff
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
                Main main = (Main)this.ParentForm;
                main.libPath = openLibPrompt.SelectedPath;
                done = true;
                this.Close();
            }
            else
            {

            }
        }

        private void NewLibBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
