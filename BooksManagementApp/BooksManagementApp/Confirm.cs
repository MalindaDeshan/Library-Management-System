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
    public partial class Confirm : Form
    {
        public Confirm()
        {
            InitializeComponent();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            Home form3 = new Home();
            string code = txtconfirm.Text;
            
            if (code == "123")
            {
                progressBar.Maximum = 100;
                progressBar.Minimum = 0;
                progressBar.Value = 99;
                MessageBox.Show("Loarding.....");
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("confirm code is wrong.!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }
    }
}
