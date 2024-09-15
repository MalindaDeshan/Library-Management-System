using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksManagementApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void insertBooksDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bookinsert form4 = new Bookinsert();
            form4.Show();
            this.Hide();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("076-0000123\nlibraryUOV@gmail.com\nUniversity of Vavuniya\nVavuniya", "About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void insertStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studentinsert form5 = new Studentinsert();
            form5.Show();
            this.Hide();
        }

        private void checkStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checkdetails form6 = new Checkdetails();
            form6.Show();
            this.Hide();
        }

        private void hereBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Showbook showbook = new Showbook();
            showbook.Show();
            this.Hide();
        }

        private void toWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeUserNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            this.Hide();
         
        }

        private void changeUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.Show();
            this.Hide();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change change=new Change();
            change.Show();
            this.Hide();
           
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
