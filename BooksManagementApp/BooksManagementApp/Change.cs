using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksManagementApp
{
    public partial class Change : Form
    {
        BooksDataDataContext dataContext = new BooksDataDataContext();
        public Change()
        {
            InitializeComponent();
            pannelsearch.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pannelsearch.Visible = true;
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            string CUsername = txtusename.Text;
            string CPassword = txtpassword.Text;
            var user=dataContext.LOGINs.SingleOrDefault(u=>u.Username == CUsername && u.Password==CPassword);
            if (user != null)
            {
                var NPassword = txtNpassword.Text;
                var CNpassword = txtCNpassword.Text;

                if (NPassword == CNpassword)
                {
                    user.Password = CNpassword;
                    MessageBox.Show("Updated password!");
                }
                else
                {
                    MessageBox.Show("Didn't match  Password!");
                }
            }
            else
            {
                MessageBox.Show("wrong your  username or Password!");
            }
                //SqlConnection conUpdate = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tharindu\Desktop\BooksManagementApp\BooksManagementApp\BooksDB.mdf;Integrated Security=True");

                //LOGIN tbluser = new LOGIN();

                //tbluser.Username =txtusename.Text;
                //tbluser.Password =txtpassword.Text;

                //var user = dataContext.LOGINs.Where(u => u.Password.Equals(txtusename.Text) && u.Username.Equals(txtusename.Text)).FirstOrDefault();

                //if (user != null)
                //{
                // tbluser.Password = txtNpassword.Text;
                //var CNpassword = txtCNpassword.Text;



                //if (tbluser.Password == CNpassword)
                // {
                //conUpdate.Open();
                // SqlCommand cmd = new SqlCommand("UPDATE  LOGIN SET Password=@password WHERE Username=@username", conUpdate);
                // cmd.Parameters.AddWithValue("@password", txtNpassword.Text);
                //cmd.CommandType = CommandType.Text;
                //cmd.ExecuteNonQuery();

                //MessageBox.Show("Updated password!");
                //}
                //else
                //{
                // MessageBox.Show("Didn't match Password!");
                // }

                //}
                //else
                //{
                //MessageBox.Show("wrong your  username or Password!");
                // }
            }

            private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            pannelupdate.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search= txtuser.Text;
            var user = dataContext.LOGINs.SingleOrDefault(u => u.Username==search);
            if(user!=null)
            {
                txtnewuser.Text =user.Username;
                MessageBox.Show("Changed username!");
            }
            else
            {
                MessageBox.Show("Not Found this user!");
            }
            //SqlConnection conUpdateusername = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2nd Year\1 semester\ACP\practical\BooksApp\BooksApp\BooksDB.mdf"";Integrated Security=True");

            //LOGIN tbluser = new LOGIN();

            //tbluser.Username=txtuser.Text;

            //var user = dataContext.LOGINs.Where(u => u.Username.Equals(txtuser.Text)).FirstOrDefault();
            //if (user != null)
            //{

            //conUpdateusername.Open();
            //SqlCommand cmd = new SqlCommand("UPDATE  UserDetail SET Username=@username WHERE Username=@username", conUpdateusername);
            //cmd.Parameters.AddWithValue("@username", txtnewuser.Text);
            //cmd.CommandType = CommandType.Text;
            //cmd.ExecuteNonQuery();

            //MessageBox.Show("Changed username!");
            //}
        }

        private void Change_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
