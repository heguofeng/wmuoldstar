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
    public partial class jibing : Form
    {
        jiating jiating; string a1; string b;
        public jibing(jiating jiating,string a1)
        {
            InitializeComponent();
            this.jiating = jiating;
            this.a1 = a1;
        }
        string[] A1 = { "是"};
        string[] A2 = { "有影响" };
        string[] A3 = { "差" };
        string[] B1 = { "经数据我们推荐您先进行营养风险测试" };
        string[] B2 = { "睡眠" };
        string[] B3 = { "衰弱Sof" };
        bool C1 = false;
        bool C2 = false;
        bool C3 = false;
        private void jibing_Load(object sender, EventArgs e)
        {

            panel2.Visible = true;
            comboBox1.Text = "正常";
            comboBox2.Text = "正常";
            comboBox3.Text = "是";
            comboBox4.Text = "有影响";
            comboBox5.Text = "好";  
            comboBox7.Text = "否";
            comboBox8.Text = "否";
            jibingDao jbd = new jibingDao();
            DataTable dt = jbd.Show(a1);
            if (dt.Rows.Count > 0)
            {
                textBox1.Text = dt.Rows[0][0].ToString();
                textBox2.Text = dt.Rows[0][1].ToString();
                comboBox1.Text = dt.Rows[0][2].ToString();
                textBox3.Text = dt.Rows[0][3].ToString();
                textBox4.Text = dt.Rows[0][4].ToString();
                comboBox2.Text = dt.Rows[0][5].ToString();
                comboBox3.Text = dt.Rows[0][6].ToString();
                comboBox4.Text = dt.Rows[0][7].ToString();
                comboBox5.Text = dt.Rows[0][8].ToString();
                //checkbox
                string[] jb_glasses = dt.Rows[0][9].ToString().Split(',');
                for (int i = 0; i < jb_glasses.Length; i++) {
                    foreach (Control ct in panel1.Controls) {
                        if (ct.Text == jb_glasses[i] && ct.GetType() == typeof(CheckBox)) {
                            ((CheckBox)ct).Checked = true;
                        }
                    }
                }
                
                    switch (dt.Rows[0][10].ToString())
                    {
                        case "是": radioButton1.Checked = true; break;
                        case "否": radioButton2.Checked = true; break;
                    }
                textBox5.Text = dt.Rows[0][11].ToString();
                textBox6.Text = dt.Rows[0][12].ToString();
                textBox9.Text = dt.Rows[0][13].ToString();
                textBox8.Text = dt.Rows[0][14].ToString();
                textBox11.Text = dt.Rows[0][15].ToString();
                textBox10.Text = dt.Rows[0][16].ToString();
                textBox13.Text = dt.Rows[0][17].ToString();
                textBox12.Text = dt.Rows[0][18].ToString();
                textBox15.Text = dt.Rows[0][19].ToString();
                textBox14.Text = dt.Rows[0][20].ToString();
                textBox17.Text = dt.Rows[0][21].ToString();
                textBox16.Text = dt.Rows[0][22].ToString();
                textBox19.Text = dt.Rows[0][23].ToString();
                textBox18.Text = dt.Rows[0][24].ToString();
                comboBox7.Text = dt.Rows[0][25].ToString();
                comboBox8.Text = dt.Rows[0][26].ToString();
                comboBox9.Text = dt.Rows[0][27].ToString();
                richTextBox1.Text = dt.Rows[0][28].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            jibingDao jbd = new jibingDao();
            DataTable dt = jbd.userNameYanzheng(a1);
            if (dt.Rows.Count ==0)
            {
                jbd.save(textBox1.Text, a1, textBox2.Text, comboBox1.Text, textBox3.Text, textBox4.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, b, (radioButton1.Checked ? "是" : "否").ToString(), textBox5.Text, textBox6.Text, textBox7.Text, textBox9.Text, textBox8.Text, textBox11.Text, textBox10.Text, textBox13.Text, textBox12.Text, textBox15.Text, textBox14.Text, textBox17.Text, textBox16.Text, textBox19.Text, textBox18.Text, comboBox7.Text, comboBox8.Text,comboBox9.Text,richTextBox1.Text);
            }
            else
            {
                jbd.update(textBox1.Text, a1, textBox2.Text, comboBox1.Text, textBox3.Text, textBox4.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, b, (radioButton1.Checked ? "是" : "否").ToString(), textBox5.Text, textBox6.Text, textBox7.Text, textBox9.Text, textBox8.Text, textBox11.Text, textBox10.Text, textBox13.Text, textBox12.Text, textBox15.Text, textBox14.Text, textBox17.Text, textBox16.Text, textBox19.Text, textBox18.Text, comboBox7.Text, comboBox8.Text, comboBox9.Text, richTextBox1.Text);
            }

            mainmenu mainmenu = new mainmenu(this.a1);
            mainmenu.Show();
            this.Hide();
          
           /* if (C3==true)
            {
                MessageBox.Show(B2[0]);
            }
            if (C1==true&&C3==true)
            {
                MessageBox.Show(B3[0]);
            }*/
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }
        //上一页
        private void button1_Click(object sender, EventArgs e)
        {
            this.jiating.Show();
            this.Close();
        }
        //测一测
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < A1.Length; i++)
            {
                if (A1[i] == comboBox3.Text)
                {
                    C1 = true;
                    break;
                }
                else { C1 = false; }
            }
            for (int i = 0; i < A2.Length; i++)
            {
                if (A2[i] == comboBox4.Text)
                {
                    C2 = true;
                    break;
                }
                else { C2 = false; }
            }
            for (int i = 0; i < A3.Length; i++)
            {
                if (A3[i] == comboBox5.Text)
                {
                    C3 = true;
                    break;
                }
                else { C3 = false; }
            }
            if (C1 == true || C2 == true)
            {
                MessageBox.Show(B1[0]);
            }
        }

       
     
      

    }
}
