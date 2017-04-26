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
    public partial class 听力 : Form
    {
        public 听力()
        {
            InitializeComponent();
        }
        int n1, n2, n3, n4, n5, n6, n7, n8,n9,n10,sum;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                n1 = 4;
            }
            else if (radioButton2.Checked)
            {
                n1 = 2;
            }
            else n1 = 0;
            if (radioButton11.Checked)
            {
                n2 = 4;
            }
            else if (radioButton4.Checked)
            {
                n2 = 2;
            }
            else n2 = 0;
            if (radioButton14.Checked)
            {
                n3 = 4;
            }
            else if (radioButton13.Checked)
            {
                n3 = 2;
            }
            else n3 = 0; 
            if (radioButton20.Checked)
            {
                n4 = 4;
            }
            else if (radioButton17.Checked)
            {
                n4 = 2;
            }
            else n4 = 0;
            if (radioButton24.Checked)
            {
                n5 = 4;
            }
            else if (radioButton23.Checked)
            {
                n5 = 2;
            }
            else n5 = 0;
            if (radioButton27.Checked)
            {
                n6 = 4;
            }
            else if (radioButton26.Checked)
            {
                n6 = 2;
            }
            else n6 = 0;
            if (radioButton30.Checked)
            {
                n7 = 4;
            }
            else if (radioButton29.Checked)
            {
                n7 = 2;
            }
            else n7 = 0;
            if (radioButton7.Checked)
            {
                n8 = 4;
            }
            else if (radioButton6.Checked)
            {
                n8 = 2;
            }
            else n8 = 0;
            if (radioButton10.Checked)
            {
                n9 = 4;
            }
            else if (radioButton9.Checked)
            {
                n9 = 2;
            }
            else n9 = 0;
            if (radioButton19.Checked)
            {
                n10 = 4;
            }
            else if (radioButton18.Checked)
            {
                n10 = 2;
            }
            else n10 = 0;
            sum = n1 + n2 + n3 + n4 + n5 + n6 + n7+n8+n9+n10;
            textBox1.Text = (sum).ToString();
            if (sum > 0 && sum < 9)
            {
                richTextBox1.Text = "13%可能有听力损害（无障碍）  O(∩_∩)O";
                richTextBox1.ForeColor = Color.Green;
                textBox1.ForeColor = Color.Green;
            }
            else if (sum > 9 && sum < 25)
            {
                richTextBox1.Text = "50%可能听力损害（轻度障碍） （⊙﹏⊙）";
                richTextBox1.ForeColor = Color.DarkOrange;
                textBox1.ForeColor = Color.DarkOrange;
            }
            else
            {
                richTextBox1.Text = "84%可能听力损害（严重障碍） (╯﹏╰）";
                richTextBox1.ForeColor = Color.Red;
                textBox1.ForeColor = Color.Red;
            }
        }
    }
}
