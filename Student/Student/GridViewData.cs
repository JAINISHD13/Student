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
    public partial class GridViewData : Form
    {
        Class1 obj = new Class1();
        public GridViewData()
        {
            InitializeComponent();
        }

        private void GridViewData_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = obj.sel("Select * from tblStudentMaster");
            dataGridView1.DataSource = dt;
            // TODO: This line of code loads data into the 'registrationDataSet.tblStudentMaster' table. You can move, or remove it, as needed.

            this.tblStudentMasterTableAdapter.Fill(this.registrationDataSet.tblStudentMaster);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainHome abc = new mainHome();
            abc.Show();
            this.Hide();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridViewData obj = new GridViewData();
            obj.Show();
            this.Hide();
        }

        private void viewDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home abc = new Home();
            abc.Show();
            this.Hide();
        }

        private void updateDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update abc = new update();
            abc.Show();
            this.Hide();
        }

        private void registrationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 abc = new Form1();
            abc.Show();
            this.Hide();
        }
    }
}