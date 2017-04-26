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
    public partial class 功能独立性 : Form
    {
        string a1;
        public 功能独立性(string a1)
        {
            InitializeComponent();
            this.a1 = a1;
        }
        int sum,sum2; string A1, A2, A3,A4;
        private void button1_Click(object sender, EventArgs e)
        {
          
          
                int n1 = int.Parse(comboBox1.Text);
                int n2 = int.Parse(comboBox2.Text);
                int n3 = int.Parse(comboBox3.Text);
                int n4 = int.Parse(comboBox4.Text);
                int n5 = int.Parse(comboBox5.Text);
                int n6 = int.Parse(comboBox6.Text);
                int n7 = int.Parse(comboBox7.Text);
                int n8 = int.Parse(comboBox8.Text);
                int n9 = int.Parse(comboBox9.Text);
                int n10 = int.Parse(comboBox10.Text);
                int n11 = int.Parse(comboBox11.Text);
                int n12 = int.Parse(comboBox12.Text);
                int n13 = int.Parse(comboBox13.Text);
                int n14 = int.Parse(comboBox14.Text);
                int n15 = int.Parse(comboBox15.Text);
                int n16 = int.Parse(comboBox16.Text);
                int n17 = int.Parse(comboBox17.Text);
                int n18 = int.Parse(comboBox18.Text);
                sum = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10 + n11 + n12 + n13 + n14 + n15 + n16 + n17 + n18;
                textBox1.Text = (sum).ToString();
                sum2=n14+n15;


                if (n1 < 4) { A1 = "Determine 营养风险监测表"; } else { A1 = ""; }
                if (n7 < 4) { A2 = "膀胱过度活动症调查表、国际尿失禁问卷表（ICI-Q-SF）、国际前列腺症状（IPSS）表"; } else { A2 = ""; }
                if (n8 < 4) { A3 = "便秘评估表"; } else { A3 = ""; }
                if (sum2 < 8) { A4 = "焦虑评估表、PHQ-9抑郁症筛查表、认知表格"; }
          
            if (sum > 107 && sum < 127)
            {
                richTextBox1.Text = "独立  O(∩_∩)O。" + "\r\n" + "建议您先进行以下测试：" + "\r\n" + A1 + "\r\n" + A2 + "\r\n" + A3 + "\r\n" + A4;
                richTextBox1.ForeColor = Color.Green;
                textBox1.ForeColor = Color.Green;
            }
            else if (sum > 53 && sum < 108)
            {
                richTextBox1.Text = "有条件依赖 （⊙﹏⊙）。" + "\r\n" + "建议您先进行以下测试：" + "\r\n" + A1 + "\r\n" + A2 + "\r\n" + A3 + "\r\n" + A4;
                richTextBox1.ForeColor = Color.DarkOrange;
                textBox1.ForeColor = Color.DarkOrange;
            }
            else
            {
                richTextBox1.Text = "完全依赖 (╯﹏╰）。" + "\r\n" + "建议您先进行以下测试：" + "\r\n" + A1 + "\r\n" + A2 + "\r\n" + A3 + "\r\n" + A4;
                richTextBox1.ForeColor = Color.Red;
                textBox1.ForeColor = Color.Red;
            }

            BasicDataDao bdd = new BasicDataDao();
            try
            {
                bdd.gn(textBox1.Text, richTextBox1.Text, this.a1);
            }
            catch (Exception)
            {

                throw;
            }

          //  MessageBox.Show("sddkjashdjakshdkjsadhksxncmxcjkdhfjkds\b /b sdasdsadsadsadsa");
        }
    }
}
