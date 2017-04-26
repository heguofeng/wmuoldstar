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
    public partial class 前列腺 : Form
    {
        string a1;
        public 前列腺(string a1)
        {
            InitializeComponent();
            this.a1 = a1;
        }
        int n1, n2, n3, n4, n5,n6,n7,sum;
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Height = 105;
            if (radioButton2.Checked)
            {
                n1 = 0;
            }
            else if (radioButton1.Checked)
            {
                n1 = 1;
            }
            else if (radioButton3.Checked)
            {
                n1 = 2;
            }
            else if (radioButton4.Checked)
            {
                n1 = 3;
            }
            else if (radioButton5.Checked)
            {
                n1 = 4;
            }
            else n1 = 5;
            if (radioButton12.Checked)
            {
                n2 = 0;
            }
            else if (radioButton11.Checked)
            {
                n2 = 1;
            }
            else if (radioButton10.Checked)
            {
                n2 = 2;
            }
            else if (radioButton9.Checked)
            {
                n2 = 3;
            }
            else if (radioButton8.Checked)
            {
                n2 = 4;
            }
            else n2 = 5;
            if (radioButton18.Checked)
            {
                n3 = 0;
            }
            else if (radioButton17.Checked)
            {
                n3 = 1;
            }
            else if (radioButton16.Checked)
            {
                n3 = 2;
            }
            else if (radioButton15.Checked)
            {
                n3 = 3;
            }
            else if (radioButton14.Checked)
            {
                n3 = 4;
            }
            else n3 = 5;
            if (radioButton24.Checked)
            {
                n4 = 0;
            }
            else if (radioButton23.Checked)
            {
                n4 = 1;
            }
            else if (radioButton22.Checked)
            {
                n4 = 2;
            }
            else if (radioButton21.Checked)
            {
                n4 = 3;
            }
            else if (radioButton20.Checked)
            {
                n4 = 4;
            }
            else n4 = 5;
            if (radioButton30.Checked)
            {
                n5 = 0;
            }
            else if (radioButton29.Checked)
            {
                n5 = 1;
            }
            else if (radioButton28.Checked)
            {
                n5 = 2;
            }
            else if (radioButton27.Checked)
            {
                n5 = 3;
            }
            else if (radioButton26.Checked)
            {
                n5 = 4;
            }
            else n5 = 5;
            if (radioButton36.Checked)
            {
                n6 = 0;
            }
            else if (radioButton35.Checked)
            {
                n6 = 1;
            }
            else if (radioButton34.Checked)
            {
                n6 = 2;
            }
            else if (radioButton33.Checked)
            {
                n6 = 3;
            }
            else if (radioButton32.Checked)
            {
                n6 = 4;
            }
            else n6 = 5;
            if (radioButton42.Checked)
            {
                n7 = 0;
            }
            else if (radioButton41.Checked)
            {
                n7 = 1;
            }
            else if (radioButton40.Checked)
            {
                n7 = 2;
            }
            else if (radioButton39.Checked)
            {
                n7 = 3;
            }
            else if (radioButton38.Checked)
            {
                n7 = 4;
            }
            else n7 = 5;
            sum = n1 + n2 + n3 + n4 + n5 + n6 + n7;
            textBox1.Text = (sum).ToString();
             if (sum>0 && sum < 8)
            {
                richTextBox1.Text = "0~7分=轻度症状  O(∩_∩)O";
                richTextBox1.ForeColor = Color.Green;
                textBox1.ForeColor = Color.Green;
            }
             else if (sum > 7 && sum < 20)
             {
                 richTextBox1.Text = "8~19分=中度症状 （⊙﹏⊙）";
                 richTextBox1.ForeColor = Color.DarkOrange;
                 textBox1.ForeColor = Color.DarkOrange;
             }
             else
             {
                 richTextBox1.Text = "20~35=重度症状 (╯﹏╰）";
                 richTextBox1.ForeColor = Color.Red;
                 textBox1.ForeColor = Color.Red;
             }

             BasicDataDao bdd = new BasicDataDao();
             try
             {
                 bdd.qianliexian(textBox1.Text, richTextBox1.Text, this.a1);
             }
             catch (Exception)
             {

                 throw;
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Height = 300;
            richTextBox1.Text = "建议" + "\r\n" 
                + "①、改变生活方式：控制体重、戒烟、改善便秘、避免咖啡和酒精等摄入" + "\r\n"
                + "②、定时或经常主动排尿，保持膀胱处于低容量状态,进行中枢神经系统和盆底肌的训练，抑制逼尿肌收缩" + "\r\n"
                + "③、认知功能正常者可以进行膀胱再训练，即清醒后定时排尿，强制性逐渐延长排尿的时间间隔；强化盆底肌的训练及电刺激盆底肌(需坚持训练)" + "\r\n"
                + "④、认知障碍的患者进行生活习惯训练，根据患者平时的排尿间隔定时排尿；按照既定计划排尿，通常每2~3小时排尿一次。";

        }  
    }
}
