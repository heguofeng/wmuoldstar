using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace StudentManagement.toolclass
{
    /// <summary>
    /// /tab帮助类，主要是进行窗口添加到tabcontrol控件里的tabpage里面
    /// 方便查看
    /// </summary>
    class TabpageHelper
    {
        private TabControl mainTab=null;
        //初始化tab帮助类并绑定相应的控件
        public TabpageHelper(TabControl mainTab) 
        { 
            this.mainTab=mainTab;
            this.mainTab.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem_1);
            //this.mainTab.MouseDown += new MouseEventHandler(tabControl1_MouseDown);
            this.mainTab.MouseMove += new MouseEventHandler(tabControl1_MouseMove);
        }

        //公有函数
        //外部调用的是这个函数
        public void Add(string str,Form from)
        {
            this.Add_TabPage(str, from);
        }
        //添加相应的窗口到tabcontrol控件里面
        //私有函数
        private void Add_TabPage(string str, Form from)
        {
            if (this.tabControlCheckHave(mainTab, str))
            {
                return;
            }
            else {
                mainTab.TabPages.Add(str);
                mainTab.SelectTab(mainTab.TabPages.Count-1);
                from.FormBorderStyle = FormBorderStyle.None;
                from.Dock = DockStyle.Fill;
                from.TopLevel = false;
                from.Show();
                from.Parent = mainTab.SelectedTab;
            }
        }
        //判断打开的窗口是否已经有你想打开的窗口
        //如果有则转到该窗口，没有则返回false
        private bool tabControlCheckHave(TabControl tab, string tabName)
        {
            for (int i = 0; i < tab.TabCount; i++) {
                if (tab.TabPages[i].Text == tabName) {
                    tab.SelectedIndex = i;
                    return true;
                }
            }

            return false;
        }
        //tabcontrol重绘item时触发该函数
        //主要是画出关闭的那个红叉
        private void tabControl1_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            try
            {
                System.Drawing.Font font = new System.Drawing.Font("黑体", 8);
                this.mainTab.TabPages[e.Index].BackColor = System.Drawing.Color.LightBlue;

                System.Drawing.Rectangle tabRect = this.mainTab.GetTabRect(e.Index);
                e.Graphics.DrawString(this.mainTab.TabPages[e.Index].Text, font, System.Drawing.SystemBrushes.ControlText,
                    (float)(tabRect.X + 2), (float)(tabRect.Y + 2));
                using (System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.DeepSkyBlue,2))
                {
                    tabRect.Offset(tabRect.Width - 17, 2);
                    tabRect.Width = 15;
                    tabRect.Height = 15;
                    //e.Graphics.DrawRectangle(pen, tabRect);
                    this.drawRadiusRectangle(e, tabRect, pen);
                }

                System.Drawing.Color color = (e.State == DrawItemState.Selected) ? System.Drawing.Color.Tomato : System.Drawing.Color.Blue;

                using (System.Drawing.Brush brush = new System.Drawing.SolidBrush(color))
                {
                    //e.Graphics.FillRectangle(brush, tabRect);
                    this.fillRadiusRectangle(e.Graphics, tabRect, brush);
                }
                //画红叉
                using (System.Drawing.Pen pen2 = new System.Drawing.Pen(System.Drawing.Color.White,2))
                {
                    System.Drawing.Point point1 = new System.Drawing.Point(tabRect.X + 3, tabRect.Y + 3);
                    System.Drawing.Point point2 = new System.Drawing.Point((tabRect.X + tabRect.Width) - 3, (tabRect.Y + tabRect.Height) - 3);
                    e.Graphics.DrawLine(pen2, point1, point2);
                    System.Drawing.Point point3 = new System.Drawing.Point(tabRect.X + 3, (tabRect.Y + tabRect.Height) - 3);
                    System.Drawing.Point point4 = new System.Drawing.Point((tabRect.X + tabRect.Width) - 3, tabRect.Y + 3);
                    e.Graphics.DrawLine(pen2, point3, point4);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        //画圆角矩形
        private void drawRadiusRectangle(DrawItemEventArgs e,System.Drawing.Rectangle rect,Pen pen) {
            //Pen pen1 = new Pen(Brushes.Blue,1);
            //pen1.Brush = Brushes.Blue;
            Rectangle rect1 = new Rectangle();
            
            rect1.X = rect.X + 6;
            rect1.Y = rect.Y;
            rect1.Width = rect.Width - 12;
            rect1.Height = rect.Height;
            //e.Graphics.DrawRectangle(pen, rect1);
            Rectangle rect2 = new Rectangle();
            
            rect2.X = rect.X;
            rect2.Y = rect.Y + 6;
            rect2.Width = rect.Width;
            rect2.Height = rect.Height - 12;
            //e.Graphics.DrawRectangle(pen,rect2);
            e.Graphics.DrawPie(pen, rect.X-1, rect.Y-1, 12, 12, 180, 90);
            e.Graphics.DrawPie(pen, rect.X + rect1.Width+1, rect.Y-1, 12, 12, 270, 90);
            e.Graphics.DrawPie(pen, rect.X + rect1.Width+1, rect.Y + rect2.Height+1, 12, 12, 0, 90);
            e.Graphics.DrawPie(pen, rect.X-1, rect.Y + rect2.Height+1, 12, 12, 90, 90);
            //边缘线
            e.Graphics.DrawLine(pen, rect1.X, rect1.Y, rect1.X + rect1.Width, rect1.Y);
            e.Graphics.DrawLine(pen, rect2.X + rect2.Width+1, rect2.Y, rect2.X + rect2.Width+1, rect2.Y + rect2.Height);
            e.Graphics.DrawLine(pen, rect1.X, rect1.Y + rect1.Height+1, rect1.X + rect1.Width, rect1.Y + rect1.Height+1);
            e.Graphics.DrawLine(pen, rect2.X, rect2.Y + rect2.Height, rect2.X, rect2.Y);
            
        }


        /// <summary>
        /// 关闭相应的TabPage页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



        //鼠标移动到关闭图形的动态效果
        private void tabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mainTab.TabCount == 0) return;
            int x = e.X;
            int y = e.Y;
            Rectangle tabRect = this.mainTab.GetTabRect(this.mainTab.SelectedIndex);

            tabRect.Offset(tabRect.Width - 17, 2);
            tabRect.Width = 15;
            tabRect.Height = 15;
            //如果鼠标点击位置处在该范围内则关闭相关窗口
            Graphics g = this.mainTab.CreateGraphics();
            if (((x > tabRect.X) && (x < tabRect.X + tabRect.Width) && (y > tabRect.Y) && (y < tabRect.Y + tabRect.Height)))
            {

                using (Brush brush = new SolidBrush(Color.Green))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    this.fillRadiusRectangle(g, tabRect, brush);
                    using (System.Drawing.Pen pen2 = new System.Drawing.Pen(System.Drawing.Color.White, 2))
                    {
                        System.Drawing.Point point1 = new System.Drawing.Point(tabRect.X + 3, tabRect.Y + 3);
                        System.Drawing.Point point2 = new System.Drawing.Point((tabRect.X + tabRect.Width) - 3, (tabRect.Y + tabRect.Height) - 3);
                        g.DrawLine(pen2, point1, point2);
                        System.Drawing.Point point3 = new System.Drawing.Point(tabRect.X + 3, (tabRect.Y + tabRect.Height) - 3);
                        System.Drawing.Point point4 = new System.Drawing.Point((tabRect.X + tabRect.Width) - 3, tabRect.Y + 3);
                        g.DrawLine(pen2, point3, point4);
                    }
                }
            }
            else
            {
                this.mainTab.Refresh();

                //System.Threading.Thread.Sleep(100);
            }
        }

        private void fillRadiusRectangle(Graphics e, System.Drawing.Rectangle rect, Brush brush)
        {
            Rectangle rect1 = new Rectangle();
            //rect1.Offset(rect.X + 2, 4);
            //Brush brush1 = new SolidBrush(Color.Red);
            rect1.X = rect.X + 6;
            rect1.Y = rect.Y;
            rect1.Width = rect.Width - 12;
            rect1.Height = rect.Height;

            Rectangle rect2 = new Rectangle();
            //rect2.Offset(rect.Width-15, 4);
            rect2.X = rect.X;
            rect2.Y = rect.Y + 6;
            rect2.Width = rect.Width;
            rect2.Height = rect.Height - 12;

            e.FillPie(brush, rect.X, rect.Y, 12, 12, 180, 90);
            e.FillPie(brush, rect.X + rect1.Width, rect.Y, 12, 12, 270, 90);
            e.FillPie(brush, rect.X + rect1.Width, rect.Y + rect2.Height, 12, 12, 0, 90);
            e.FillPie(brush, rect.X, rect.Y + rect2.Height, 12, 12, 90, 90);

            e.FillRectangle(brush, rect1);
            e.FillRectangle(brush, rect2);

        }



        
    }
}
