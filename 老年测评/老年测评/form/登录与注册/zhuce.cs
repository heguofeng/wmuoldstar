using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace 老年测评
{
    public partial class zhuce : Form
    {
        denglu denglu;
        public zhuce(denglu denglu)
        {
            InitializeComponent();
            this.denglu=denglu;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

            this.Close();
            denglu.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*    string sql = "insert into users(name,psd,cn,birth,sex,email,image) values(@name,@psd,@cn,@birth,@sex,@email,@image)  ";//sql添加数据语句 
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@name",textBox1.Text),
                    new SqlParameter("@psd",textBox2.Text),
                    new SqlParameter("@cn",textBox4.Text),
                    new SqlParameter("@email",textBox5.Text),
                     new SqlParameter("@birth",dateTimePicker1.Value.ToString("yyyy-MM-dd")),
                     new SqlParameter("@sex",(radioButton1.Checked ? "男":"女").ToString()),
                     new SqlParameter("@image",openFileDialog1.FileName),
                };*/

            UsesDao zc = new UsesDao();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                if (Regex.IsMatch(textBox4.Text, "^[\u4e00-\u9fa5]{0,}$"))
                {
                    if (Regex.IsMatch(textBox5.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)" + @"|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))//IsMatch 方法通常用于验证字符串
                    {

                        if (textBox2.Text == textBox3.Text)
                        {
                            if (zc.zhuce(textBox1.Text, textBox2.Text, textBox4.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), (radioButton1.Checked ? "男" : "女").ToString(), textBox5.Text, openFileDialog1.FileName) == 1)
                            {
                                MessageBox.Show("注册成功","提示");
                                denglu.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("注册失败", "提示");
                            }
                        }
                        else
                        {
                            MessageBox.Show("两次密码输入不一致！", "提示");
                            textBox2.Text = "";
                            textBox3.Text = "";
                        }
                    }

                    else
                    {
                        MessageBox.Show("请输入正确的邮箱格式,比如zhuce@zhuze.com", "提示");
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("请输入正确的中文姓名");
                    return;
                }
            }

            else
            {
                MessageBox.Show("请完善信息！", "提示");
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
                  

        private void button3_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            string fileString = openFileDialog1.FileName;
            pictureBox1.Load(fileString);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)//此处查看该用户名是否存在
        {

            UsesDao loginname = new UsesDao();
            DataTable dt = loginname.userNameYanzheng(textBox1.Text);
            if (dt.Rows.Count > 0)
            {
                label7.Text = "该用户名已注册";
                label7.ForeColor = Color.Red;
                textBox1.Focus();
            }
            else
            {
                label7.Text = "恭喜，用户名未注册";
                label7.ForeColor = Color.Blue;
                button1.Enabled = true;
            }
        }


    }
}
