using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 老年测评.form
{
    public partial class 步态 : Form
    {
        string a1;
        public 步态(string a1)
        {
            InitializeComponent();
            this.a1 = a1;
           
        }
        int n1, n20,n21,n22,n23, n3, n4, n5, n6, n7,sum;
        private void tinetti测试_Load(object sender, EventArgs e)
        {
            
        }


        public void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                n1 = 1;
            }
            else { n1 = 0; }
            if (radioButton3.Checked)
            {
                n20 = 1;
            }
            else { n20 = 0; }
            if (radioButton5.Checked)
            {
                n21 = 1;
            }
            else { n21 = 0; }
            if (radioButton7.Checked)
            {
                n22 = 1;
            }
            else { n22 = 0; }
            if (radioButton9.Checked)
            {
                n23 = 1;
            }
            else { n23 = 0; }
            if (radioButton11.Checked)
            {
                n3 =1;
            }
            else { n3 = 0; }
            if (radioButton13.Checked)
            {
                n4 = 1;
            }
            else { n4 = 0; }
            if (radioButton17.Checked)
            {
                n5 = 2;
            }
            else if (radioButton15.Checked)
            {
                n5 = 1;
            }
            else
            {
                n5 = 0;
            }
            if (radioButton18.Checked)
            {
                n6 = 2;
            }
            else if (radioButton19.Checked)
            {
                n6 = 1;
            }
            else
            {
                n6 = 0;
            }
            if (radioButton21.Checked)
            {
                n7 = 1;
            }
            else { n7 = 0; }
            sum=n1 + n20 + n21 + n22 + n23 + n3 + n4 + n5 + n6 + n7;
            textBox1.Text = (sum).ToString();
            richTextBox1.Text = "分数越高，移动功能越好!  O(∩_∩)O";

            BasicDataDao bdd = new BasicDataDao();
            try
            {
                bdd.butai(textBox1.Text, richTextBox1.Text, this.a1);
            }
            catch (Exception)
            {

                throw;
            }
        }  
    }
}
