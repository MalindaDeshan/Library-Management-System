using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksManagementApp
{
    public partial class Delete : Form
    {
        BooksDataDataContext dataContext = new BooksDataDataContext();
        public Delete()
        {
            InitializeComponent();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //SqlConnection conDelete = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tharindu\Desktop\BooksManagementApp\BooksManagementApp\BooksDB.mdf;Integrated Security=True");

                try
                {
                    string del = txtusername.Text;
                    var dl = dataContext.LOGINs.SingleOrDefault(u => u.Username == del);
                    var delete = MessageBox.Show("Do you want delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (delete == DialogResult.Yes)
                    {
                        dataContext.LOGINs.DeleteOnSubmit(dl);
                        dataContext.SubmitChanges();
                        MessageBox.Show("Deleted Data!");

                    }
                    else
                    { }
                //conDelete.Open();
                //SqlCommand cmd = new SqlCommand("DELETE FROM LOGIN WHERE Username=@username", conDelete);
                //cmd.Parameters.AddWithValue("@username", txtusername.Text);
                //cmd.CommandType = CommandType.Text;
                // cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error..!", ex.Message);
                }
                finally
                {
                    //Close();
                }
        }

        private void Delete_Load(object sender, EventArgs e)
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
