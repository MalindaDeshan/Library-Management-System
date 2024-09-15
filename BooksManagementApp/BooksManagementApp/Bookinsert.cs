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
    public partial class Bookinsert : Form
    {
        BooksDataDataContext dataContext=new BooksDataDataContext();
        public Bookinsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            BOOK booktable = new BOOK();
            booktable.BID = txtBid.Text;
            booktable.BName = txtBname.Text;
            booktable.Author = txtaouthor.Text;

            dataContext.BOOKs.InsertOnSubmit(booktable);
            dataContext.SubmitChanges();
            MessageBox.Show("Details Entered!");
            txtBid.Clear();
            txtBname.Clear();
            txtaouthor.Clear();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBid.Clear();
            txtBname.Clear();
            txtaouthor.Clear();
            if (MessageBox.Show("Do you need Close the this window?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Bookinsert_Load(object sender, EventArgs e)
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
