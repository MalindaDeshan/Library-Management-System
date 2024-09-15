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
    public partial class Showbook : Form
    {
        BooksDataDataContext dataContext = new BooksDataDataContext();
        public Showbook()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            List<BOOK> bookdisplay = dataContext.BOOKs.ToList();
            dataGridView1.DataSource = bookdisplay;
        }

        private void Showbook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
