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
    public partial class Home : Form
    {
        Class1 obj = new Class1();

        public Home()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = obj.sel("select * from tblStudentMaster where Enroll ='" + txtenorollment.Text + "'");
            if (dt.Rows.Count == 1)
            {
                groupBox1.Show();
                groupBox2.Show();
                lblMsg.Hide();
                label2.Text = dt.Rows[0][1].ToString();
                label4.Text = dt.Rows[0][2].ToString();
                label6.Text = dt.Rows[0][3].ToString();
                label8.Text = dt.Rows[0][4].ToString();
                label10.Text = dt.Rows[0][5].ToString();
                label12.Text = dt.Rows[0][6].ToString();
                label14.Text = dt.Rows[0][7].ToString();
                label2.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                groupBox1.Hide();
                groupBox2.Hide();
                lblMsg.Show();
                lblMsg.Text = "No Data Found";
                
            }
        }


        private void Home_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            lblMsg.Hide();

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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
