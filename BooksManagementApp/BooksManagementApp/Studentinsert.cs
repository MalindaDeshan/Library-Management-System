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
    public partial class Studentinsert : Form
    {
        BooksDataDataContext dataContext = new BooksDataDataContext();
        public Studentinsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            STUDENT sttable = new STUDENT();
            sttable.STID = txtid.Text;
            sttable.STName = txtname.Text;
            sttable.STmail = txtmail.Text;
            sttable.STNo = txtno.Text;
            dataContext.STUDENTs.InsertOnSubmit(sttable);
            dataContext.SubmitChanges();
            MessageBox.Show("Details Entered!");
            txtid.Clear();
            txtname.Clear();
            txtmail.Clear();
            txtno.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtmail.Clear();
            txtno.Clear();


            if (MessageBox.Show("Do you need Close the this window?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Studentinsert_Load(object sender, EventArgs e)
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
