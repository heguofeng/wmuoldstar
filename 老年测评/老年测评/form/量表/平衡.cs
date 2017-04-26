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
    public partial class 平衡 : Form
    {
        string a1;
        public 平衡(string a1)
        {
            InitializeComponent();
            this.a1 = a1;
        }
        int n1, n2, n3, n4, n5, n6, n7, n8, n9,n10, sum;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                n1 = 1;
            }
          
            else n1 = 0;
            if (radioButton22.Checked)
            {
                n2 = 2;
            }
            else if (radioButton3.Checked)
            {
                n2 = 1;
            }
            else n2 = 0;
            if (radioButton6.Checked)
            {
                n3 = 2;
            }
            else if (radioButton11.Checked)
            {
                n3 = 1;
            }
            else n3 = 0;
            if (radioButton5.Checked)
            {
                n4 = 2;
            }
            else if (radioButton13.Checked)
            {
                n4 = 1;
            }
            else n4 = 0;
            if (radioButton15.Checked)
            {
                n5 = 2;
            }
            else if (radioButton17.Checked)
            {
                n5 = 1;
            }
            else n5 = 0;
            if (radioButton18.Checked)
            {
                n6 = 2;
            }
            else if (radioButton19.Checked)
            {
                n6 = 1;
            }
            else n6 = 0;
            if (radioButton21.Checked)
            {
                n7 = 1;
            }
           
            else n7 = 0;
            if (radioButton7.Checked)
            {
                n8 = 1;
            }
           
            else n8 = 0;
            if (radioButton28.Checked)
            {
                n9 = 1;
            }
          
            else n9 = 0;
            if (radioButton24.Checked)
            {
                n10 = 2;
            }
            else if (radioButton9.Checked)
            {
                n10 = 1;
            }
            else n10 = 0;
            sum = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10;
            textBox1.Text = (sum).ToString();
            if (sum > 0 && sum < 6)
            {
                richTextBox1.Text = "您的平衡性较差  (╯﹏╰）";
                richTextBox1.ForeColor = Color.Red;
                textBox1.ForeColor = Color.Red;
            }
            else if (sum > 5 && sum < 12)
            {
                richTextBox1.Text = "您的平衡性一般 （⊙﹏⊙）";
                richTextBox1.ForeColor = Color.DarkOrange;
                textBox1.ForeColor = Color.DarkOrange;
            }
            else
            {
                richTextBox1.Text = "平衡较好  O(∩_∩)O";
                richTextBox1.ForeColor = Color.Green;
                textBox1.ForeColor = Color.Green;
               
            }

            BasicDataDao bdd = new BasicDataDao();
            try
            {
                bdd.pinghen(textBox1.Text, richTextBox1.Text, this.a1);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
