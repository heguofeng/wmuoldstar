using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 老年测评.Dao;

namespace 老年测评.form
{
    public partial class jiating : Form
    {
       
        string a1;//name
        string b;//照料者
        public jiating(string a1)
        {
            InitializeComponent();
            
            this.a1 = a1;
        }
        
        
        string[] A1 = {"未婚","离异","丧偶"};
        string[] A2 = { "养老院", "医院"};
        string[] A3 = { "否"};
        string[] B1 = { "根据您填写的信息，我们建议您进一步填写 PHQ-9抑郁症筛查表 和 焦虑评估表，以便于我们详细分析您的具体情况" };
        bool C1 = false;
        bool C2 = false;
        bool C3 = false;
        private void button2_Click(object sender, EventArgs e)//“家庭”
        {
            b = "";
            foreach (Control ct in panel1.Controls)//关于checkbox值的代码
            {
                if (ct.GetType() == typeof(CheckBox) && ((CheckBox)ct).Checked == true)
                {
                    b += ct.Text + ",";
                }
            }
            if (b.Length > 0)
            {
                b = b.Substring(0, b.Length - 1);
            }//结束后把字符串最后一个逗号去掉

            jiatingDao jtd = new jiatingDao();
            DataTable dt = jtd.userNameYanzheng(a1);//判断是更新还是增加用户
            if (dt.Rows.Count ==0)
            {
                jtd.save(a1, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, textBox1.Text, b);
            }
            else
            {
                jtd.update(a1, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, textBox1.Text, b);
            }

            jibing jibing = new jibing(this, this.a1);
            this.Hide();
            jibing.Show();       
 
            
        }

        private void jiating_Load(object sender, EventArgs e)
        {
            jiatingDao jtd = new jiatingDao();
            DataTable dt = jtd.Show(a1);
            if (dt.Rows.Count > 0)
            {
                comboBox1.Text = dt.Rows[0][0].ToString();
                comboBox2.Text = dt.Rows[0][1].ToString();
                comboBox3.Text = dt.Rows[0][2].ToString();
                comboBox4.Text = dt.Rows[0][3].ToString();
                comboBox5.Text = dt.Rows[0][4].ToString();
                textBox1.Text = dt.Rows[0][5].ToString();
                string[] jt_care = dt.Rows[0][6].ToString().Split(',');
                for (int i = 0; i < jt_care.Length; i++) {
                    foreach (Control ct in panel1.Controls) {
                        if (ct.Text == jt_care[i] && ct.GetType() == typeof(CheckBox)) {
                            ((CheckBox)ct).Checked = true;
                        }
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasicData BasicData = new BasicData(this.a1);
            BasicData.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < A1.Length; i++)
            {
                if (A1[i] == comboBox1.Text)
                {
                    //  label16.Text = B1[0];
                    //   MessageBox.Show(B1[0]);
                    C1 = true;
                    break;
                }
                else { C1 = false; }
            }
            for (int i = 0; i < A2.Length; i++)
            {
                if (A2[i] == comboBox2.Text)
                {
                    //  label16.Text = B1[0];
                    //  MessageBox.Show(B1[0]);
                    C2 = true;
                    break;
                }
                else { C2 = false; }

            }
            for (int i = 0; i < A3.Length; i++)
            {
                if (A3[i] == comboBox5.Text)
                {
                    // label16.Text = B1[0];
                    //  MessageBox.Show(B1[0]);
                    C3 = true;
                    break;
                }
                else { C3 = false; }

            }
            if (C1 == false && C2 == false && C3 == false)
            {
                // label16.Text = "12 ";
                MessageBox.Show("11111111111111");

            }
            else
            {
                //  label16.Text = B1[0];

                MessageBox.Show(B1[0], "提示");

            }
        }
    }
}
