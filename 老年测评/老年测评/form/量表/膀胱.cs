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
    public partial class 膀胱 : Form
    {
        string a1;
        public 膀胱(string a1)
        {
            InitializeComponent();
            this.a1 = a1;
        }
        int n1, n2, n3, n4, sum;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                n1 = 0;
            }
            else if (radioButton1.Checked)
            {
                n1 = 1;
            }
            else n1 = 2;
            if (radioButton6.Checked)
            {
                n2 = 0;
            }
            else if (radioButton5.Checked)
            {
                n2 = 1;
            }
            else if (radioButton4.Checked)
            {
                n2 = 2;
            }
            else n2 = 3;
            if (radioButton10.Checked)
            {
                n3 = 0;
            }
            else if (radioButton11.Checked)
            {
                n3 = 1;
            }
            else if (radioButton9.Checked)
            {
                n3 = 2;
            }
            else if (radioButton12.Checked)
            {
                n3 = 3;
            }
            else if (radioButton13.Checked)
            {
                n3 = 4;
            }
            else n3 = 5;
            if (radioButton18.Checked)
            {
                n4 = 0;
            }
            else if (radioButton19.Checked)
            {
                n4 = 1;
            }
            else if (radioButton17.Checked)
            {
                n4 = 2;
            }
            else if (radioButton15.Checked)
            {
                n4 = 3;
            }
            else if (radioButton16.Checked)
            {
                n4 = 4;
            }
            else n4 = 5;
            sum = n1 + n2 + n3 + n4 ;
            textBox1.Text = (sum).ToString();
            if (n3 > 2 && sum > 3)
            {
                richTextBox1.Text = "如果问题3（尿急）的得分在2分以上，且整个得分在3分以上，就可诊断膀胱过度活动症，应去泌尿外科接受进一步诊疗  (╯﹏╰）";
                richTextBox1.ForeColor = Color.Red;
                textBox1.ForeColor = Color.Red;
            }
            else if (sum <= 3)
            {
                richTextBox1.Text = "正常  O(∩_∩)O";
                richTextBox1.ForeColor = Color.Green;
                textBox1.ForeColor = Color.Green;
            }

            BasicDataDao bdd = new BasicDataDao();
            try
            {
                bdd.pangguang(textBox1.Text, richTextBox1.Text, this.a1);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
