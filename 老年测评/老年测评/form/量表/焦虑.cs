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
    public partial class 焦虑 : Form
    {
        string a1;
        public 焦虑(string a1)
        {
            InitializeComponent();
            this.a1 = a1;
        }
        int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16, n17, n18, n19, n20; double sum;
        private void 焦虑_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                n1 = 1;
            }
            else if (radioButton2.Checked)
            {
                n1 = 2;
            }
            else if (radioButton22.Checked)
            {
                n1 = 3;
            }
            else n1=4;
            if (radioButton7.Checked)
            {
                n2 = 1;
            }
            else if (radioButton6.Checked)
            {
                n2 = 2;
            }
            else if (radioButton5.Checked)
            {
                n2 = 3;
            }
            else n2 = 4;
            if (radioButton11.Checked)
            {
                n3 = 1;
            }
            else if (radioButton10.Checked)
            {
                n3 = 2;
            }
            else if (radioButton9.Checked)
            {
                n3 = 3;
            }
            else n3 = 4;
            if (radioButton15.Checked)
            {
                n4 = 1;
            }
            else if (radioButton14.Checked)
            {
                n4 = 2;
            }
            else if (radioButton13.Checked)
            {
                n4 = 3;
            }
            else n4 = 4;
            if (radioButton19.Checked)
            {
                n5 = 1;
            }
            else if (radioButton18.Checked)
            {
                n5 = 2;
            }
            else if (radioButton17.Checked)
            {
                n5 = 3;
            }
            else n5 = 4;
            if (radioButton24.Checked)
            {
                n6 = 1;
            }
            else if (radioButton23.Checked)
            {
                n6 = 2;
            }
            else if (radioButton21.Checked)
            {
                n6 = 3;
            }
            else n6 = 4;
            if (radioButton28.Checked)
            {
                n7 = 1;
            }
            else if (radioButton27.Checked)
            {
                n7 = 2;
            }
            else if (radioButton26.Checked)
            {
                n7 = 3;
            }
            else n7 = 4;
            if (radioButton32.Checked)
            {
                n8 = 1;
            }
            else if (radioButton31.Checked)
            {
                n8 = 2;
            }
            else if (radioButton30.Checked)
            {
                n8 = 3;
            }
            else n8 = 4;
            if (radioButton36.Checked)
            {
                n9 = 1;
            }
            else if (radioButton35.Checked)
            {
                n9 = 2;
            }
            else if (radioButton34.Checked)
            {
                n9= 3;
            }
            else n9 = 4;
            if (radioButton40.Checked)
            {
                n10 = 1;
            }
            else if (radioButton39.Checked)
            {
                n10 = 2;
            }
            else if (radioButton38.Checked)
            {
                n10 = 3;
            }
            else n10 = 4;
            if (radioButton80.Checked)
            {
                n11 = 1;
            }
            else if (radioButton79.Checked)
            {
                n11 = 2;
            }
            else if (radioButton78.Checked)
            {
                n11 = 3;
            }
            else n11 = 4;
            if (radioButton74.Checked)
            {
                n12 = 1;
            }
            else if (radioButton76.Checked)
            {
                n12 = 2;
            }
            else if (radioButton75.Checked)
            {
                n12 = 3;
            }
            else n12 = 4;
            if (radioButton70.Checked)
            {
                n13 = 1;
            }
            else if (radioButton72.Checked)
            {
                n13 = 2;
            }
            else if (radioButton71.Checked)
            {
                n13 = 3;
            }
            else n13 = 4;
            if (radioButton66.Checked)
            {
                n14 = 1;
            }
            else if (radioButton68.Checked)
            {
                n14 = 2;
            }
            else if (radioButton67.Checked)
            {
                n14 = 3;
            }
            else n14 = 4;
            if (radioButton62.Checked)
            {
                n15 = 1;
            }
            else if (radioButton64.Checked)
            {
                n15 = 2;
            }
            else if (radioButton63.Checked)
            {
                n15 = 3;
            }
            else n15 = 4;
            if (radioButton58.Checked)
            {
                n16 = 1;
            }
            else if (radioButton60.Checked)
            {
                n16= 2;
            }
            else if (radioButton59.Checked)
            {
                n16 = 3;
            }
            else n16 = 4;
            if (radioButton54.Checked)
            {
                n17 = 1;
            }
            else if (radioButton56.Checked)
            {
                n17 = 2;
            }
            else if (radioButton55.Checked)
            {
                n17 = 3;
            }
            else n17 = 4;
            if (radioButton51.Checked)
            {
                n18 = 1;
            }
            else if (radioButton52.Checked)
            {
                n18 = 2;
            }
            else if (radioButton50.Checked)
            {
                n18 = 3;
            }
            else n18 = 4;
            if (radioButton46.Checked)
            {
                n19 = 1;
            }
            else if (radioButton48.Checked)
            {
                n19 = 2;
            }
            else if (radioButton47.Checked)
            {
                n19 = 3;
            }
            else n19 = 4;
            if (radioButton42.Checked)
            {
                n20 = 1;
            }
            else if (radioButton44.Checked)
            {
                n20 = 2;
            }
            else if (radioButton43.Checked)
            {
                n20 = 3;
            }
            else n20 = 4;

            sum = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10 + n11 + n12 + n13 + n14 + n15 + n16 + n17 + n18 + n19 + n20;
            double sum2 = sum * 1.25;
            textBox1.Text = (sum2).ToString();
            if (sum2 > 70)
            {
                richTextBox1.Text = "重度焦虑  (╯﹏╰）";
                richTextBox1.ForeColor = Color.Red;
                textBox1.ForeColor = Color.Red;
            }
            else if (sum2 > 59 && sum2 < 70)
            {
                richTextBox1.Text = "中度焦虑 （⊙﹏⊙）";
                richTextBox1.ForeColor = Color.DarkOrange;
                textBox1.ForeColor = Color.DarkOrange;
            }
            else
            {
                richTextBox1.Text = "轻度焦虑  O(∩_∩)O";
                richTextBox1.ForeColor = Color.Green;
                textBox1.ForeColor = Color.Green;

            }

            BasicDataDao bdd = new BasicDataDao();
            try
            {
                bdd.jiaolv(textBox1.Text, richTextBox1.Text, this.a1);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
