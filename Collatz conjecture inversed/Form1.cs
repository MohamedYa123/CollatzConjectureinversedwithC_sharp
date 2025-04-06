using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collatz_conjecture_inversed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* List<int> pattern = new List<int>();
             pattern.Add(3);
             pattern.Add(4);
             pattern.Add(7);
             pattern.Add(1);
             var a=  CollatzAgent.FindNumberFromPattern(1, pattern);
             MessageBox.Show(a + "");*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BigInteger num = BigInteger.Parse(richTextBox1.Text);
            var pattern = CollatzAgent.ExtractPattern(num, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox3.Text), checkBox1.Checked);
            listBox1.Items.Clear();
            object[] objs = new object[pattern.Count];
            sum = 0;
            for (int i = 0; i < pattern.Count; i++)
            {
                objs[i] = pattern[i];
                sum += pattern[i];
            }
            listBox1.Items.Clear();
            listBox1.Items.AddRange(objs);
            label3.Text = $"sum:{sum}";
            richTextBox1.Text = richTextBox1.Text.Replace("\r\n", "");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                button2_Click(null, null);
                // button2.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                button3.PerformClick();
                return;
            }
            sum += Convert.ToInt32(textBox2.Text);
            var c = Convert.ToInt32(textBox2.Text);
            textBox2.Text = "";
            if (c <= 0)
            {
                return;
            }
            listBox1.Items.Add(c);
            label3.Text = $"sum:{sum}";
        }
        int sum = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            List<int> pattern = new List<int>();
            foreach (var a in listBox1.Items)
            {
                pattern.Add(Convert.ToInt32(a));
            }
            if (pattern.Count == 0) { return; }
            var num = CollatzAgent.FindNumberFromPattern(Convert.ToInt32(textBox1.Text), pattern);
            richTextBox1.Text = num + "";
            textBox3.Text = sum + "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            BigInteger big = BigInteger.Parse(richTextBox1.Text.Replace("\r", "").Replace("\n", ""));
            int ns = 0;
            while (big > 0)
            {
                big = big >> 1;
                ns += 1;
            }
            label4.Text = $"2^({ns}) digits:{richTextBox1.Text.Length}";
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                button1_Click(null, null);
                // button2.PerformClick();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                button1_Click(null, null);
                // button2.PerformClick();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                button1_Click(null, null);
                // button2.PerformClick();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            //MessageBox.Show("This App is Built by: Mohamed yasser\r\nEmail:mohamedyasser112025@gmail.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Encode encode = new Encode();
            encode.ShowDialog();
        }
    }
}
