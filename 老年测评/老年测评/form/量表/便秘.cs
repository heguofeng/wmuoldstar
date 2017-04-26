using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 老年测评.form;

namespace 老年测评.form
{
    public partial class 便秘 : Form
    {
        string a1;
        public 便秘(string a1)
        {
            InitializeComponent();
            this.a1 = a1;
        }
        int n1, n2, n3, n4, n5, sum;

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Height = 105;
            
            if (radioButton2.Checked) { n1 = 1; }
            else n1 = 0;
            if (radioButton3.Checked) { n2 = 1; }
            else n2 = 0;
            if (radioButton4.Checked) { n3 = 1; }
            else n3 = 0;
            if (radioButton5.Checked) { n4 = 1; }
            else n4 = 0;
            if (radioButton6.Checked) { n5 = 1; }
            else n5 = 0;
            sum = n1 + n2 + n3 + n4 + n5;
            textBox1.Text = (sum).ToString();
            if (sum < 3)
            {
                richTextBox1.Text = "0~2分：良好  O(∩_∩)O";
                richTextBox1.ForeColor = Color.Green;
                textBox1.ForeColor = Color.Green;
            }
            else
            {
                richTextBox1.Text = "总分≥2时可判断为便秘  (╯﹏╰）";
                richTextBox1.ForeColor = Color.Red;
                textBox1.ForeColor = Color.Red;
            }


            BasicDataDao bdd = new BasicDataDao();
            try
            {
                bdd.bianmi(textBox1.Text, richTextBox1.Text,this.a1);
            }
            catch (Exception)
            {
                
                throw;
            }
          
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Height = 300;
            richTextBox1.Text = "建议"+"\r\n"+
                "①、饮食方面：热卡充足，富含纤维素，充足液体摄入"+"\r\n"+
                "②、增加活动"+"\r\n"+
                "③、避免大量饮酒和过多咖啡饮品"+"\r\n"+
                "④、制定规律性排空计划"+"\r\n"+
                "⑤、采用端坐位排便；排便时吸气、鼓腹；用双手上托肛门两侧"+"\r\n"+
                "⑥、制定肛门收缩训练";
        }
    }
}
