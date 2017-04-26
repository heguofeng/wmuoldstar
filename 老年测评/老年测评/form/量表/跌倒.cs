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
    public partial class 跌倒 : Form
    {
        string a1;
        public 跌倒(string a1)
        {
            InitializeComponent();
            this.a1 = a1;
        }
        int n1, n2, n3, n4, n5, n6, sum;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                n1 = 0;
            }
            else n1 = 25;

            if (radioButton4.Checked)
            {
                n2 = 0;
            }
            else n2 = 15;
            if (radioButton12.Checked || radioButton15.Checked || radioButton11.Checked)
            {
                n3 = 0;
            }
            else if (radioButton6.Checked || radioButton5.Checked)
            {
                n3 = 15;
            }
            else n3 = 30;
            if (radioButton14.Checked)
            {
                n4 = 0;
            }
            else n4 = 20;
            if (radioButton16.Checked || radioButton17.Checked || radioButton10.Checked)
            {
                n5 = 0;
            }
            else if (radioButton18.Checked)
            {
                n5 = 10;
            }
            else n5 = 30;
            if (radioButton9.Checked)
            {
                n6 = 0;
            }
            else n6 = 15;
            sum = n1 + n2 + n3 + n4 + n5 + n6;
            textBox1.Text = (sum).ToString();
            if ( sum < 25)
            {
                richTextBox1.Text = "小于25分为低风险  O(∩_∩)O";
                richTextBox1.ForeColor = Color.Green;
                textBox1.ForeColor = Color.Green;
            }
            else if (sum > 24 && sum < 46)
            {
                richTextBox1.Text = "25至45分为中度风险 （⊙﹏⊙）";
                richTextBox1.ForeColor = Color.DarkOrange;
                textBox1.ForeColor = Color.DarkOrange;
            }
            else
            {
                richTextBox1.Text = "大于45分确定为跌倒高风险 (╯﹏╰）";
                richTextBox1.ForeColor = Color.Red;
                textBox1.ForeColor = Color.Red;
            }

            BasicDataDao bdd = new BasicDataDao();
            try
            {
                bdd.diedao(textBox1.Text, richTextBox1.Text, this.a1);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
