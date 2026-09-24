using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assig1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtsemester_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string student_name, student_id, department, semester, fulldata;
                student_name = txtname.Text;
                student_id = txtstudentid.Text;
                department = txtdepartment.Text;
                semester = txtsemester.Text;
                fulldata = student_name + " " + student_id + " " + department + " " + semester;
                lbloutput.Text = fulldata;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lbloutput.Text = " ";
           
        }
    }
}
