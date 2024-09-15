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
    public partial class Add : Form
    {
        BooksDataDataContext dataContext = new BooksDataDataContext();
        public Add()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LOGIN tbllogin = new LOGIN();

             tbllogin.Username= txtusername.Text;
             tbllogin.Password = txtpassword.Text;

            dataContext.LOGINs.InsertOnSubmit(tbllogin);
            dataContext.SubmitChanges();
            MessageBox.Show("Details Entered!");
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
