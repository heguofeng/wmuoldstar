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
    public partial class 营养 : Form
    {
        string a1;
        public 营养(string a1)
        {
            InitializeComponent();
            this.a1 = a1;
        }
        int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, sum;
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Height = 105;
            if (radioButton2.Checked) { n1 = 2; }
            else n1 = 0;
            if (radioButton3.Checked) { n2 = 3; }
            else n2 = 0;
            if (radioButton4.Checked) { n3 = 2; }
            else n3 = 0;
            if (radioButton5.Checked) { n4 = 2; }
            else n4 = 0;
            if (radioButton6.Checked) { n5 = 2; }
            else n5 = 0;
            if (radioButton7.Checked) { n6 = 4; }
            else n6 = 0;
            if (radioButton8.Checked) { n7 = 1; }
            else n7 = 0;
            if (radioButton9.Checked) { n8 = 1; }
            else n8 = 0;
            if (radioButton10.Checked) { n9 = 2; }
            else n9 = 0;
            if (radioButton11.Checked) { n10 = 2; }
            else n10 = 0;
            sum = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10;
            textBox1.Text = (sum).ToString();
            if (sum < 3)
            {
                richTextBox1.Text = "0~2分：请保持现有的饮食情况，每6个月测评一次即可  O(∩_∩)O";
                richTextBox1.ForeColor = Color.Green;
                textBox1.ForeColor = Color.Green;
            }
            else if (sum > 2 && sum < 6)
            {
                richTextBox1.Text = "3~5分您有轻、中度的营养不良危险，请向专业人员咨询，进行饮食和生活习惯的改变，每3个月评估1次 （⊙﹏⊙）";
                richTextBox1.ForeColor = Color.DarkOrange;
                textBox1.ForeColor = Color.DarkOrange;
            }
            else
            {
                richTextBox1.Text = "大于6分，您有高度营养不良危险，请寻找医师或营养师帮助，改善营养状态。 (╯﹏╰）";
                richTextBox1.ForeColor = Color.Red;
                textBox1.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Height = 300;
            richTextBox1.Text = "建议"+"\r\n"+
"1.尽可能根据老年人对事物的喜好，加强食物摄入，可以通过改变食物的色泽、质地、温度和设计，并将用一些调味剂来弥补老年人因衰老而退化的味觉和嗅觉。同时也可以减少盐和糖的摄入" + "\r\n" +
"2.除非是临床上必需的，应尽量避免治疗性饮食，以免引起摄入受限或不足" + "\r\n" +
"3.进食时，老年患者应先完成餐前准备，如佩戴眼镜、义齿（假牙），洗手，漱口等，并处于比较舒服的进食体位。进餐时，应保证比较充足的进餐时间" + "\r\n" +
"4.老年患者应尽可能口服膳食，或选择经口营养补充剂（ONS），尽量选择适合老年人口味、高浓度的流质饮食" + "\r\n" +
"5.若口服饮食不及需要量的50%，需给予管饲饮食。管饲时首选鼻饲，应采用匀速滴入的方法，从低浓度、低剂量开始，逐渐增加" + "\r\n" +
"6.病情重且需要营养支持较久（超过四到六周）时，可考虑造口术，包括内镜辅助下的胃/空肠造口，或开腹手术做胃或空肠造口术" + "\r\n" +
"7.依据老年人的特点，多选用平衡营养，富含蛋白质和少量脂肪，以及易于消化吸收的含纤维的配方" + "\r\n" +
"8.标准营养补充剂多含有均衡的常量和微量营养素，有固体的和液体的。可以根据患者的偏好和咀嚼能力以及营养制剂的价格来选择";
        }
    }
}
