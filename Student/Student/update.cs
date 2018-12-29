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
    public partial class update : Form
    {
        String gender;
        Class1 obj = new Class1();
        public update()
        {
            InitializeComponent();
        }

        private void update_Load(object sender, EventArgs e)
        {
            lbl.Show();
            txteno.Show();
            button1.Show();
            groupBox1.Hide();
            button2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
                if (radioButton1.Checked == true)
                {
                    gender = "Male";
                }
                else if (radioButton2.Checked = true)
                {
                    gender = "Female";
                }

                obj.ins_updt_del("update tblStudentMaster set Name='" + this.textBox1.Text + "',Branch='" + this.textBox2.Text + "',Semester='" + this.comboBox1.SelectedItem.ToString() + "',Address='" + this.textBox3.Text + "',Email='" + this.textBox4.Text + "',Gender='" +gender + "' where Enroll="+this.txteno.Text+"");
                lbl.Text = "Data Updated Successfully";
                lbl.Visible = true;
                groupBox1.Hide();
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
            this.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update abc = new update();
            abc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = obj.sel("select * from tblStudentMaster where Enroll ='" + txteno.Text + "'");

            groupBox1.Show();

            if (dt.Rows.Count == 1)
            {
                groupBox1.Show();
                button2.Show();
                lbl.Hide();
                txteno.Hide();
                button1.Hide();
            }
            else
            {
                lbl.Text = "Data Not Found";
                groupBox1.Hide();
            }

        }
    }
}
