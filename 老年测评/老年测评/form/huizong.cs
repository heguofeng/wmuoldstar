using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 老年测评.form;
using 老年测评.Dao;

namespace 老年测评.form
{
    public partial class huizong : Form
    {
        string a1;
        public huizong(string a1)
        {
            InitializeComponent();
            this.a1 = a1;
        }

        private void huizong_Load(object sender, EventArgs e)
        {
            
            BasicDataDao bdd = new BasicDataDao();
            itemsDao itd = new itemsDao();
         
            DataTable dtA = itd.items();
            DataTable dtB = bdd.huizong(a1);
            DataTable dtC = itd.huizongB(a1);
            if (dtC.Rows.Count == 0) return;
            if (dtB.Rows.Count == 0) return;
           
            listView1.Columns.Add("项目", 200);
            listView1.Columns.Add("得分", 200);
            listView1.Columns.Add("测试结果", 500);
            int i;
            try
            {
                for (i = 0; i < 15; i++)
                {
                    listView1.Items.Add(dtA.Rows[0][i].ToString());
                    listView1.Items[i].SubItems.Add(dtB.Rows[0][i].ToString());                  
                    listView1.Items[i].SubItems.Add(dtC.Rows[0][i].ToString());
                }
            }
            catch (Exception)
            {

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainmenu mainmenu = new mainmenu(this.a1);
            mainmenu.Show();
            this.Close();
        }
    }
}
