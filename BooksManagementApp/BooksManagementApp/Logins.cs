using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BooksManagementApp
{
    public partial class Logins : Form
    {
        public string name, password;
        public Logins()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Confirm form2 = new Confirm();
            name = txtusername.Text;
            password = txtpassword.Text;

            if (name == "Admin" && password == "123admin")
            {
                txtpassword.Clear();
                txtusername.Clear();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("wrong Username or Password", "! Warning");
            }

        }
    }
}
