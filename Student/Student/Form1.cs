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
    public partial class Form1 : Form
    {
        Class1 obj = new Class1();
        String gender;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                gender = "Male";
            }
            else if(radioButton2.Checked==true)
            {
               gender = "Female";
            }

            obj.ins_updt_del("insert into tblStudentMaster values( '" +txteno.Text+"','"+txtname.Text+"','"+txtbranch.Text+"','"+comboBox1.SelectedItem.ToString()+"','"+txtpass.Text+"','"+txtadd.Text+"','"+txtemail.Text+"','"+gender+"')");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home abc = new Home();
            abc.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainHome abc = new mainHome();
            abc.Show();
            this.Hide();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update abc = new update();
            abc.Show();
            this.Hide();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home abc = new Home();
            abc.Show();
            this.Hide();
        }
    }
}
