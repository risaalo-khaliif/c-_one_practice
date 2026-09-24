using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_assigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //creating a variable
            string dayof_Week, name_of_month,  fulldata;
            int numeric_day;
            int year;

            //intial values to variable
            dayof_Week = txtDayoftheweek.Text;
            name_of_month = txtdayofthemonth.Text;
            numeric_day = 
            year =
             int.Parse ( txtofthemonth.Text);
            int.Parse(txtYEAR.Text);

            //strage 2 process conction of full data
            fulldata = dayof_Week + " " + name_of_month + " " + numeric_day + " " + year;
            lpoutput.Text = fulldata;
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
         //for
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //cllearing textbox and label
            //clearing textbox
            txtDayoftheweek.Clear();
            txtdayofthemonth.Clear();
            txtofthemonth.Clear();
            txtYEAR.Clear();

            //clearing label not used clear function
            lpoutput.Text = " ";

        }
    }
}
