using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentManagement.toolclass;

namespace 老年测评.form
{
    public partial class mainmenu : Form
    {
        string a1;
        public mainmenu(string a1)
        {
            InitializeComponent();
            
            this.a1 = a1;
            
        }
        TabpageHelper TP = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            TP = new TabpageHelper(this.tabControl1);
          toolStripStatusLabel1.Text = a1.ToString() + "用户，你好！";
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            功能独立性 功能独立性 = new 功能独立性(this.a1);
            TP.Add("功能独立性", 功能独立性);
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (tabControl1.TabCount == 0) return;
            if (e.Button == MouseButtons.Left)
            {

                int x = e.X;
                int y = e.Y;
                Rectangle tabRect = this.tabControl1.GetTabRect(this.tabControl1.SelectedIndex);

                tabRect.Offset(tabRect.Width - 15, 2);
                tabRect.Width = 15;
                tabRect.Height = 15;
                //如果鼠标点击位置处在该范围内则关闭相关窗口

                if (((x > tabRect.X) && (x < tabRect.X + tabRect.Width) && (y > tabRect.Y) && (y < tabRect.Y + tabRect.Height)))
                {
                    this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab); return;
                }
            }
        } 

        private void button2_Click_1(object sender, EventArgs e)
        {
            衰弱 衰弱 = new 衰弱(this.a1);
            TP.Add("衰弱",衰弱);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            焦虑 焦虑 = new 焦虑(this.a1);
            TP.Add("焦虑", 焦虑);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            抑郁症 抑郁症 = new 抑郁症(this.a1);
            TP.Add("抑郁症", 抑郁症);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            营养 营养 = new 营养(this.a1);
            TP.Add("营养",营养);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            平衡 平衡 = new 平衡(this.a1);
            TP.Add("平衡", 平衡);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            步态 步态 = new 步态(this.a1);
            TP.Add("步态", 步态);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            跌倒 跌倒 = new 跌倒(this.a1);
            TP.Add("跌倒", 跌倒);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            便秘 便秘 = new 便秘(this.a1);
            TP.Add("便秘", 便秘);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            膀胱 膀胱 = new 膀胱(this.a1);
            TP.Add("膀胱", 膀胱);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            尿失禁 尿失禁 = new 尿失禁();
            TP.Add("尿失禁", 尿失禁);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            前列腺 前列腺 = new 前列腺(this.a1);
            TP.Add("前列腺", 前列腺);
        }
        //MMSE认知
        private void button13_Click(object sender, EventArgs e)
        {
            MMSE mmse = new MMSE();
            TP.Add("MMSE", mmse);
        }
        //MINI认知
        private void button14_Click(object sender, EventArgs e)
        {
            MINI mini = new MINI();
            TP.Add("MINI", mini);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            睡眠 睡眠 = new 睡眠(this.a1);
            TP.Add("睡眠", 睡眠);
        }

        //汇总
        private void button18_Click(object sender, EventArgs e)
        {
            huizong huizong = new huizong(this.a1);
            huizong.Show();
            this.Hide();
        }

       
        private void button17_Click(object sender, EventArgs e)
        {
            BasicData BasicData = new BasicData(this.a1);
            BasicData.Show();
            this.Hide();

        }

    }
}
