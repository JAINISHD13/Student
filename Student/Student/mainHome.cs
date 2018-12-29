using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class mainHome : Form
    {
        public mainHome()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainHome abc = new mainHome();
            abc.Show();
            this.Hide();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 abc = new Form1();
            abc.Show();
            this.Hide();

        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home abc = new Home();
            abc.Show();
            this.Hide();

        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update abc = new update();
            abc.Show();
            this.Hide();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridViewData obj = new GridViewData();
            obj.Show();
            this.Hide();

        }
    }
}
