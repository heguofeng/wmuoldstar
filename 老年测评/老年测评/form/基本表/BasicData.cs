using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 老年测评.form;

namespace 老年测评
{
    public partial class BasicData : Form
    {
       
        string a1;
        float h, w, BMI;
       
        public BasicData( string a1)
        {
            InitializeComponent();
            this.a1 = a1;
           
           
        }

        private void button2_Click(object sender, EventArgs e)  //“下一页”
        {
            
          
           
            BasicDataDao bdd = new BasicDataDao();
            DataTable dt = bdd.userNameYanzheng(a1);
            //识别是否保存还是更新信息
            if (dt.Rows.Count == 0)
            {
                bdd.save(label4.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox22.Text, comboBox1.Text, (radioButton4.Checked ? "在职" : "退休").ToString(), textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox77.Text, (radioButton6.Checked ? "是" : "否").ToString(), textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, comboBox2.Text, (radioButton8.Checked ? "有" : "无").ToString(), textBox16.Text, textBox17.Text, textBox18.Text, (radioButton10.Checked ? "有" : "无").ToString(), textBox21.Text, textBox20.Text, textBox19.Text, a1);
            }
            else
            {
                bdd.update(label4.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox22.Text, comboBox1.Text, (radioButton4.Checked ? "在职" : "退休").ToString(), textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox77.Text, (radioButton6.Checked ? "是" : "否").ToString(), textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, comboBox2.Text, (radioButton8.Checked ? "有" : "无").ToString(), textBox16.Text, textBox17.Text, textBox18.Text, (radioButton10.Checked ? "有" : "无").ToString(), textBox21.Text, textBox20.Text, textBox19.Text, a1);
            }
           

            jiating jiating = new jiating(this.a1);
            this.Hide();
            jiating.Show(); 

        }

     

        private void yhjm_Load(object sender, EventArgs e)
        {
            textBox14.Enabled = false;
            label4.Text = DateTime.Now.ToString("yyyy年MM月dd日");
            comboBox1.Text = "文盲及半文盲";
            comboBox2.Text = "自费";
            BasicDataDao bdd = new BasicDataDao();
            DataTable dtA = bdd.getName(a1);
            if (dtA.Rows.Count == 0) return;
            textBox1.Text = dtA.Rows[0][0].ToString();
            textBox2.Text = dtA.Rows[0][1].ToString();
            textBox22.Text = dtA.Rows[0][2].ToString();

            try
            {
                pictureBox1.Image = Image.FromFile(dtA.Rows[0][3].ToString());
    
            }
            catch (Exception)
            {

               // MessageBox.Show("!");
            }
          
            DataTable dtB = bdd.Show(a1);
            if (dtB.Rows.Count == 0) return;
            textBox1.Text = dtB.Rows[0][0].ToString();
            textBox2.Text = dtB.Rows[0][1].ToString();
            textBox3.Text = dtB.Rows[0][2].ToString();
            textBox22.Text = dtB.Rows[0][3].ToString();
            comboBox1.Text = dtB.Rows[0][4].ToString();
            //if (dtB.Rows[0][5].ToString() == "在职" ? radioButton4.Checked = true : radioButton3.Checked = true) return; 
            switch (dtB.Rows[0][5].ToString())
            {
                case "在职": radioButton4.Checked = true; break;
                case "退休": radioButton3.Checked = true; break;
            }
            textBox4.Text = dtB.Rows[0][6].ToString();
            textBox5.Text = dtB.Rows[0][7].ToString();
            textBox6.Text = dtB.Rows[0][8].ToString();
            textBox7.Text = dtB.Rows[0][9].ToString();
            textBox77.Text = dtB.Rows[0][10].ToString();
            switch (dtB.Rows[0][11].ToString())
            {
                case "是": radioButton6.Checked = true; break;
                case "否": radioButton5.Checked = true; break;
            }
            textBox8.Text = dtB.Rows[0][12].ToString();
            textBox9.Text = dtB.Rows[0][13].ToString();
            textBox10.Text = dtB.Rows[0][14].ToString();
            textBox11.Text = dtB.Rows[0][15].ToString();
            textBox12.Text = dtB.Rows[0][16].ToString();
            textBox13.Text = dtB.Rows[0][17].ToString();
            textBox14.Text = dtB.Rows[0][18].ToString();
            comboBox1.Text = dtB.Rows[0][19].ToString();
            switch (dtB.Rows[0][20].ToString())
            {
                case "有": radioButton8.Checked = true; break;
                case "无": radioButton7.Checked = true; break;
            }
            textBox16.Text = dtB.Rows[0][21].ToString();
            textBox17.Text = dtB.Rows[0][22].ToString();
            textBox18.Text = dtB.Rows[0][23].ToString();
            switch (dtB.Rows[0][24].ToString())
            {
                case "有": radioButton10.Checked = true; break;
                case "无": radioButton9.Checked = true; break;
            } 
            textBox21.Text = dtB.Rows[0][25].ToString();
            textBox20.Text = dtB.Rows[0][26].ToString();
            textBox19.Text = dtB.Rows[0][27].ToString();
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainmenu mainmenu = new mainmenu(this.a1);
            mainmenu.Show();
            this.Hide();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e) //是否显示后面信息
        {
            if (radioButton7.Checked)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)//是否显示后面信息
        {
            if (radioButton9.Checked)
            {
                panel6.Visible = false;
            }
            else
            {
                panel6.Visible = true;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)//是否显示后面信息
        {
            if (radioButton5.Checked)
            {
                panel7.Visible = false;
            }
            else
            {
                panel7.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                float h = float.Parse(textBox12.Text); float w = float.Parse(textBox13.Text);
               
                BMI = w / (h * h);
                textBox14.Enabled = true;
                textBox14.Text = BMI.ToString("f2");  //两位小数点
            }
            catch (Exception)
            {
                if (textBox12.Text == "" || textBox13.Text == "")
                {
                    MessageBox.Show("请输入正确的身高与体重信息！", "提示");
                    return;
                }
                
               
            }
           
            if (BMI < 18.5) { MessageBox.Show("体重指数（BMI）小于18.5，偏瘦状态，建议您待会进行 营养风险检测 测试。", "提示"); }
            if (BMI >= 18.5 && BMI <= 23.9) { MessageBox.Show("体重指数（BMI）非常正常", "提示"); }
            if (BMI >= 24 && BMI <= 27.9) { MessageBox.Show("体重指数（BMI）大于24，偏肥状态，建议您待会进行 营养风险检测 测试。", "提示"); }
            if (BMI >= 28) { MessageBox.Show("体重指数（BMI）大于28，肥胖状态，建议您待会进行 营养风险检测 测试。", "提示"); }
        }



        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

    

       
    }
}
