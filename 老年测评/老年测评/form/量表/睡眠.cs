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
    public partial class 睡眠 : Form
    {
        string a1;
        public 睡眠(string a1)
        {
            InitializeComponent();
            this.a1 = a1;
        }
        int n4, n44,na, nb, nc, nd, ne, nf, ng, nh, ni, nj, n6, n7, n8, n9;
        public void 睡眠_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox3.Height = 105;
            double n2 = double.Parse(textBox2.Text);
            try
            {
                n2 = double.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("请填写完整");
               
            }
            
            int n22;
            if (n2 <= 15)
            {
                n22 = 0;
            }
            else if (n2 > 15 && n2 < 31)
            {
                n22 = 1;
            }
            else if (n2 > 30 && n2 < 61)
            {
                n22 = 2;
            }
            else n22 = 3;
            double n4 = double.Parse(textBox4.Text);
            try
            {
                n4 = double.Parse(textBox4.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("请填写完整");
                
            }
            
            if (n4 >7 )
            {
                n44 = 0;
            }
            else if (n4 > 6 && n4 < 7)
            {
                n44 = 1;
            }
            else if (n4 > 5 && n4 < 6)
            {
                n44 = 2;
            }
            else n44= 3;
            if (radioButton1.Checked)
            {
                na = 0;
            }
            else if (radioButton2.Checked)
            {
                na = 1;
            }
            else if (radioButton3.Checked)
            {
                na = 2;
            }
            else na = 3;
            if (radioButton6.Checked)
            {
                nb = 0;
            }
            else if (radioButton7.Checked)
            {
                nb = 1;
            }
            else if (radioButton8.Checked)
            {
                nb = 2;
            }
            else nb = 3;
            if (radioButton10.Checked)
            {
                nc = 0;
            }
            else if (radioButton11.Checked)
            {
                nc = 1;
            }
            else if (radioButton12.Checked)
            {
                nc = 2;
            }
            else nc = 3;
            if (radioButton14.Checked)
            {
                nd = 0;
            }
            else if (radioButton15.Checked)
            {
                nd = 1;
            }
            else if (radioButton16.Checked)
            {
                nd = 2;
            }
            else nd = 3;
            if (radioButton18.Checked)
            {
                ne = 0;
            }
            else if (radioButton19.Checked)
            {
                ne = 1;
            }
            else if (radioButton20.Checked)
            {
                ne = 2;
            }
            else ne = 3;
            if (radioButton22.Checked)
            {
                nf = 0;
            }
            else if (radioButton23.Checked)
            {
                nf = 1;
            }
            else if (radioButton24.Checked)
            {
                nf = 2;
            }
            else nf = 3;
            if (radioButton26.Checked)
            {
                ng = 0;
            }
            else if (radioButton27.Checked)
            {
                ng= 1;
            }
            else if (radioButton28.Checked)
            {
                ng = 2;
            }
            else ng = 3;
            if (radioButton34.Checked)
            {
                nh = 0;
            }
            else if (radioButton35.Checked)
            {
                nh = 1;
            }
            else if (radioButton36.Checked)
            {
                nh = 2;
            }
            else nh = 3;
            if (radioButton38.Checked)
            {
                ni = 0;
            }
            else if (radioButton39.Checked)
            {
                ni = 1;
            }
            else if (radioButton40.Checked)
            {
                ni = 2;
            }
            else ni = 3;
            if (radioButton82.Checked)
            {
                nj = 0;
            }
            else if (radioButton83.Checked)
            {
                nj = 1;
            }
            else if (radioButton84.Checked)
            {
                nj = 2;
            }
            else nj = 3;
            if (radioButton86.Checked)
            {
                n6 = 0;
            }
            else if (radioButton87.Checked)
            {
                n6 = 1;
            }
            else if (radioButton88.Checked)
            {
                n6 = 2;
            }
            else n6 = 3;
            if (radioButton90.Checked)
            {
                n7 = 0;
            }
            else if (radioButton91.Checked)
            {
                n7 = 1;
            }
            else if (radioButton92.Checked)
            {
                n7 = 2;
            }
            else n7 = 3;
            if (radioButton94.Checked)
            {
                n8 = 0;
            }
            else if (radioButton95.Checked)
            {
                n8 = 1;
            }
            else if (radioButton96.Checked)
            {
                n8 = 2;
            }
            else n8 = 3;
            if (radioButton98.Checked)
            {
                n9 = 0;
            }
            else if (radioButton99.Checked)
            {
                n9 = 1;
            }
            else if (radioButton100.Checked)
            {
                n9 = 2;
            }
            else n9 = 3;

            /*A睡眠质量：根据条目6的应答计分“较好”计1分，“较差”计2分，“很差”计3分。
            B入睡时间:累加条目2和5a的计分，若累加分为“0”计0分，“1~2”计1分，“3~4”计2分，“5~6”计3分
             c睡眠时间：根据条目4的应答计分，“>7小时”计0分，“6~7”计1分，“5~6”计2分，“<5小时”计3分。
             * D睡眠效率 = 条目4/（条目3- 条目1）× 100%, 睡眠效率 > 85%计0分，75~84% 计1分，65~74%计2分，< 65% 计3分。
            * E睡眠障碍:条目5b至5j的累加分为“0”则成分E计0分，“1~9”计1分，“10~18”计2分，“19~27”计3分。
             * F催眠药物:根据条目7的应答计分，“无”计0分，“<1周/次”计1分，“1~2周/次”计2分，“≥3周/次”计3分。
             * G日间功能障碍：⒊ 累加条目8和9的得分，若累加分为“0”则成分G计0分，“1~2”计1分，“3~4”计2分，“5~6”计3分*/
             int nA = n6;
            int nB = n22 + na;
            int nBB,nEE,nGG;
            if (nB >= 1 && nB <= 2)
            {
                nBB = 1;
            }
            else if (nB == 0)
            {
                nBB = 0;
            }
            else if (nB >= 3 && nB <= 4)
            {
                nBB = 2;
            }
            else nBB = 3;
            int nC = n44;

            int nE = nb + nc + nd + ne + nf + ng + nh + ni + nj;
            if (nE >= 1 && nE <= 9)
            {
                nEE = 1;
            }
            else if (nE == 0)
            {
                nEE = 0;
            }
            else if (nE >= 10 && nE <= 18)
            {
                nEE = 2;
            }
            else nEE = 3;
            int nF = n7;
            int nG = n8 + n9;
            if (nG>= 1 && nG <= 2)
            {
                nGG = 1;
            }
            else if (nG == 0)
            {
                nGG = 0;
            }
            else if (nG >= 3 && nG <= 4)
            {
                nGG = 2;
            }
            else nGG = 3;
            int sum = nA + nBB + nC + nEE + nF + nGG;
             textBox5.Text = (sum).ToString();
             if (sum>=0 && sum <= 5)
            {
                richTextBox3.Text = "0~5分=睡眠质量还好  O(∩_∩)O";
                richTextBox3.ForeColor = Color.Green;
                textBox5.ForeColor = Color.Green;
            }
             else if (sum >=6 && sum <=10)
             {
                 richTextBox3.Text = "6~10分=睡眠质量还行 （⊙﹏⊙）";
                 richTextBox3.ForeColor = Color.DarkOrange;
                 textBox5.ForeColor = Color.DarkOrange;
             }
             else if (sum >=11 && sum <=15)
             {
                 richTextBox3.Text = "11~15分=睡眠质量一般 （⊙﹏⊙）";
                 richTextBox3.ForeColor = Color.DarkOrange;
                 textBox5.ForeColor = Color.DarkOrange;
             }
             else if (sum >= 16 && sum <= 21)
             {
                 richTextBox3.Text = "20~35=睡眠质量很差 (╯﹏╰）";
                 richTextBox3.ForeColor = Color.Red;
                 textBox5.ForeColor = Color.Red;
             }

             BasicDataDao bdd = new BasicDataDao();
             try
             {
                 bdd.shuimian (textBox5.Text, richTextBox3.Text, this.a1);
             }
             catch (Exception)
             {

                 throw;
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox3.Height = 300;
            richTextBox3.Text = "建议" + "\r\n"
                + "①、非药物治疗：每日锻炼，但在睡前两小时内避免剧烈运动；日间享受充分光照，避免午睡或打盹；午餐后限制咖啡因、尼古丁的使用，戒酒；不要在床上做与睡眠无关的事情，如读书或看电视；保持卧室安静而黑暗，温度略低；如果上床20分钟内不能入睡，起床做一些轻柔的动作；不要饿着肚子上床，但睡前也不要吃得太饱。" + "\r\n"
                + "②、药物治疗：采用最低有效剂量；不要在老年人中使用非处方药中的抗组胺药物治疗失眠；对发作性的失眠患者使用短效药物（如唑吡坦、扎来普隆）；对持续失眠患者，使用长效药物（如左旋佐匹克隆）；采用间隔给药法（每周2~4次）；短期应用药物（不超过3~4周）；逐渐停药；警惕停药后失眠反弹；镇静催眠药物均会增加跌倒风险。";

        }

      
    }
}
