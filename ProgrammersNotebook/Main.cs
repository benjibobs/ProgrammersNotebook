using System;
using System.Windows.Forms;

namespace ProgrammersNotebook
{
    public partial class Main : Form
    {

        public string libPath = "";

        /* Custom */
        private int WidthDivideBy(int divider)
        {
            return Screen.FromControl(this).Bounds.Width / divider;
        }

        private int HeightDivideBy(int divider)
        {
            return Screen.FromControl(this).Bounds.Height / divider;
        }

        /* Auto generated */
        public Main()
        {
            InitializeComponent();
            library.Width = WidthDivideBy(4);
            noteList.Width = WidthDivideBy(4);
            note.Width = WidthDivideBy(2);

            NewOrOpenForm startDia = new NewOrOpenForm();
            startDia.ShowDialog(this);

            if (!startDia.done || libPath == "")
            {
                //this.Close();
                Application.Exit();
                return;
            }



        }

        private void Library_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void noteList_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
