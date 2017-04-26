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
    public partial class 抑郁症 : Form
    {
        string a1;
        public 抑郁症(string a1)
        {
            InitializeComponent();
            this.a1 = a1;
        }

        Control[] GetControls()
        {
            List<Control> controls = new List<Control>();
            foreach (Control control in this.Controls)
                if (control is RadioButton)
                    controls.Add(control);
            return controls.ToArray();
        }

        int y1, y2, y3, y4, y5, y6, y7, y8, y_sum, rb_sum;
        private void button1_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = "抱歉，本测试尚再调试中，暂时无法使用。";



               richTextBox1.Height = 105;
                //选项一
                if (radioButton2.Checked) {
                    y1 = 0;
                }
                else if (radioButton1.Checked) {
                    y1 = 1;
                }
                else if (radioButton3.Checked)
                {
                    y1 = 2;
                }
                else {
                    y1 = 3;
                }
                //选项二
                if (radioButton8.Checked) {
                    y2 = 0;
                }
                else if (radioButton7.Checked) {
                    y2 = 1;
                }
                else if (radioButton6.Checked)
                {
                    y2 = 2;
                }
                else {
                    y2 = 3;
                }
                //选项三
                if (radioButton12.Checked)
                {
                    y3 = 0;
                }
                else if (radioButton11.Checked)
                {
                    y3 = 1;
                }
                else if (radioButton10.Checked)
                {
                    y3 = 2;
                }
                else
                {
                    y3 = 3;
                }
                //选项四
                if (radioButton16.Checked)
                {
                    y4 = 0;
                }
                else if (radioButton15.Checked)
                {
                    y4 = 1;
                }
                else if (radioButton14.Checked)
                {
                    y4 = 2;
                }
                else
                {
                    y4 = 3;
                }
                //选项五
                if (radioButton20.Checked)
                {
                    y5 = 0;
                }
                else if (radioButton19.Checked)
                {
                    y5 = 1;
                }
                else if (radioButton18.Checked)
                {
                    y5 = 2;
                }
                else
                {
                    y5 = 3;
                }
                //选项六
                if (radioButton24.Checked)
                {
                    y6 = 0;
                }
                else if (radioButton23.Checked)
                {
                    y6 = 1;
                }
                else if (radioButton22.Checked)
                {
                    y6 = 2;
                }
                else
                {
                    y6 = 3;
                }
                //选项七
                if (radioButton28.Checked)
                {
                    y7 = 0;
                }
                else if (radioButton27.Checked)
                {
                    y7 = 1;
                }
                else if (radioButton26.Checked)
                {
                    y7 = 2;
                }
                else
                {
                    y7 = 3;
                }
                //选项八
                if (radioButton32.Checked)
                {
                    y8 = 0;
                }
                else if (radioButton31.Checked)
                {
                    y8 = 1;
                }
                else if (radioButton30.Checked)
                {
                    y8 = 2;
                }
                else
                {
                    y8 = 3;
                } 
                y_sum = y1 + y2 + y3 + y4 + y5 + y6 + y7 + y8;
                textBox1.Text = y_sum.ToString();

            //给出建议
                if (y_sum >= 0 && y_sum <= 4) {
                    richTextBox1.Text = "没有抑郁症！";
                }
                else if (y_sum >= 5 && y_sum <= 9) {
                    richTextBox1.Text = "可能有轻微抑郁症！";
                }
                else if (y_sum >= 10 && y_sum <= 14) {
                    richTextBox1.Text = "可能有中度抑郁症！";
                }
                else if (y_sum >= 15 && y_sum <= 19)
                {
                    richTextBox1.Text = "可能有中重度抑郁症！";
                }
                else {
                    richTextBox1.Text = "可能有重度抑郁症！";
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Height = 500;
            richTextBox1.Text="建议"+"\r\n"+
            "1.夫妇需要齐心协力来对抗抑郁症。对于夫妻来说，敌人是疾病本身，而不是患有抑郁症的伴侣。面对患有抑郁症的伴侣时一定要共同努力来对抗疾病，而不是任由疾病发展影响婚姻。积极的合作能够改善伴侣的情况，夫妻可以尝试每天一起散步，一起去看医生或者在伴侣吃药时进行必要的鼓励和监督。"+"\r\n"+
            "2.不要动怒，也不要因为生病的伴侣觉得丢脸。和出现了抑郁症状的伴侣生活可能让你产生愤怒和怨恨的情绪，这种情况在其中一方冷落另一方时常常会出现，甚至是不愿意轮流做家务之类的小事也可能触发愤怒和怨恨情绪。当伴侣中的一方出现孤僻和冷漠的情况时，伴侣之间的性生活和亲密程度也会受到影响，也有人会因为伴侣出现了精神疾病的症状而感到羞愧，这样的倾向是不利于患有抑郁症的个体寻求医疗帮助的。"+"\r\n"+
            "3.帮助伴侣进行恰当的诊断和治疗。疾病本身可能会让抑郁症患者难以意识到自己生病了，也会让他们不愿意寻求帮助，所以一般情况下要由健康的另一半来提出建议并制定行动计划。要打开“去看医生”这件事的话匣子，可以尝试说“我很在乎你，不愿意看到你受苦，抑郁症是一种很常见的疾病没有什么好丢脸的，一起去看医生然后治好它吧”之类的劝导。"+"\r\n"+
            "4.接受现状。鼓励自己患有抑郁症的伴侣表达自己的感受和想法，耐心的聆听。如果抑郁的症状严重，患者说出的话可能会让你觉得很吓人，据贝尔医生介绍，有的抑郁症患者可能会怀疑自己对另一半的爱或者想要在一起的想法，面对这种情况，最好在抑郁症症状过去之后再做去做一些决定。"+"\r\n"+
            "5.陪伴他们去看医生。在看医生时有另一半的陪伴对于抑郁症患者来说极其的重要，因为对于医生来说健康的另一半能够提供非常丰富的有用信息，把你所观察到的情况向医生介绍是很有帮助的。未患抑郁症的另一半是可能最先发现伴侣出现症状的人，关于伴侣的看法在治疗过程中能够提供很多参考。"+"\r\n"+
            "6.在给孩子们介绍情况时要根据子女年龄酌情处理。抑郁症不仅会影响婚姻，也会影响到所有家庭成员的生活，孩子们也是很容易察觉到异样的人。要用一种诚实但又谨慎的方式告诉孩子们病人的病情，不要让孩子们感到焦虑和恐惧。一些患有抑郁症的父母也表示，像需要早起送孩子上学这样的对孩子们的责任感可以帮助病人本身对抗病魔。"+"\r\n"+
            "7.在治疗过程中保持耐心。关于抑郁症的治疗走一些弯路是正常的，不过医生们通过药物和谈话疗法一般是能够让抑郁症患者有所好转的，也能够改善患者们的生活。要相信耐心的进行治疗，抑郁症能够被克服。" + "\r\n" +
            "8.要明白抑郁症是一种反复的疾病。当伴侣中的一方患上抑郁症时，可能会经历一些很糟糕的阶段，也会有情况较好的时候。这种反复对于“夫妻治疗”的手段具有一定指示作用，当患者情况较好时，夫妻中的一方就要进行一些工作来改善夫妻关系。";
        }
    }
}
