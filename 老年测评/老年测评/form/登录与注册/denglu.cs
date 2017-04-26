using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 老年测评
{
    public partial class denglu : Form
    {
         string a1;
        public denglu()
        {
            InitializeComponent();
           Sunisoft.IrisSkin.SkinEngine skin=new Sunisoft.IrisSkin.SkinEngine();
         //  skin.SkinFile = System.Environment.CurrentDirectory + "\\skins\\" + "WaveColor1.ssk";
            skin.Active=true;
            
        }
        


        private void button1_Click(object sender, EventArgs e)//登录
        {
            a1 = textBox1.Text;
            UsesDao ud = new UsesDao();
            DataTable dt = ud.login(textBox1.Text, textBox2.Text);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                BasicData BasicData = new BasicData( this.a1);
                BasicData.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码不正确");
                return;
            }
          
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor =Color.Blue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            zhuce zhuce = new zhuce(this);
            zhuce.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
