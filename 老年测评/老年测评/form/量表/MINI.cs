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
    public partial class MINI : Form
    {
        public MINI()
        {
            InitializeComponent();
        }

        private void MINI_Load(object sender, EventArgs e)
        {
            listView1.Items.Add("0");
            listView1.Items[0].SubItems.Add("正常");
            listView1.Items[0].SubItems.Add("√");
            listView1.Items.Add("0");
            listView1.Items[1].SubItems.Add("不正常");
            listView1.Items[1].SubItems.Add("√");
            listView1.Items.Add("1");
            listView1.Items[2].SubItems.Add("正常");
            listView1.Items[2].SubItems.Add("×");
            listView1.Items.Add("1");
            listView1.Items[3].SubItems.Add("不正常");
            listView1.Items[3].SubItems.Add("√");
            listView1.Items.Add("2");
            listView1.Items[4].SubItems.Add("正常");
            listView1.Items[4].SubItems.Add("×");
            listView1.Items.Add("2");
            listView1.Items[5].SubItems.Add("不正常");
            listView1.Items[5].SubItems.Add("√");
            listView1.Items.Add("3");
            listView1.Items[6].SubItems.Add("正常");
            listView1.Items[6].SubItems.Add("×");
            listView1.Items.Add("3");
            listView1.Items[7].SubItems.Add("不正常");
            listView1.Items[7].SubItems.Add("×");
        }
    }
}
