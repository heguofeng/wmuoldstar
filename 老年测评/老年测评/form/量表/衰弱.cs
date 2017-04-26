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
    public partial class 衰弱 : Form
    {
        string a1;
        public 衰弱(string a1)
        {
            InitializeComponent();
            this.a1 = a1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0; // 定义一个值 判断checkbox被选中的个数有几个
            foreach (Control ct in this.Controls) {
                if (ct.GetType() == typeof(CheckBox) && ((CheckBox)ct).Checked == true) {
                    num = num + 1;
                }
            }
            if (num >= 2)
            {
                this.richTextBox1.Text = "超过两条，您的健康出现衰弱 (╯﹏╰）";
                richTextBox1.ForeColor = Color.Red;
                
            }
            else {
                this.richTextBox1.Text = "您的健康没有问题  O(∩_∩)O";
                richTextBox1.ForeColor = Color.Green;
               
            }

            BasicDataDao bdd = new BasicDataDao();
            try
            {
                bdd.shuairuo(richTextBox1.Text, this.a1);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
