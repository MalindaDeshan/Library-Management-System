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
    public partial class Checkdetails : Form
    {
        BooksDataDataContext dataContext = new BooksDataDataContext();
        public Checkdetails()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            STUDENT filter = new STUDENT();
            var filterStID = txtfiter.Text;

            List<STUDENT> stfilter = dataContext.STUDENTs.Where(x => x.STID.Equals(filterStID)).ToList();
            dataGridView1.DataSource = stfilter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Checkdetails_Load(object sender, EventArgs e)
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
