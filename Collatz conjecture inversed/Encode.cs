using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Numerics;
using System.Linq;
namespace Collatz_conjecture_inversed
{
    public partial class Encode : Form
    {
        public Encode()
        {
            InitializeComponent();
        }
        int tots = 0;
        private async void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = of.FileName;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tots != 0)
            {
                label1.Text = $"{CollatzAgent.patternreached}/{tots}";
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            (List<int> pattern, int inversed) = (null, 0);
            await Task.Run(() => { (pattern, inversed) = CollatzAgent.ConvertBytestoPattern(File.ReadAllBytes(textBox1.Text)); });
            tots = pattern.Count;
            BigInteger c = 0;
            await Task.Run(() => { c = CollatzAgent.FindNumberFromPattern(1, pattern); });
            byte[] bigintbytes = c.ToByteArray();
            int kc = pattern.Sum()*inversed;
            byte[] bts = BitConverter.GetBytes(kc);
            byte[] bytes = new byte[bigintbytes.Length + bts.Length];
            for (int i = 0; i < bytes.Length; i++)
            {
                if (i < bts.Length)
                {
                    bytes[i] = bts[i];
                }
                else
                {
                    bytes[i] = bigintbytes[i - bts.Length];
                }
            }
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(sv.FileName, bytes);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (BigInteger bi, int patternlength) = CollatzAgent.ConvertBytesTonumber(File.ReadAllBytes(textBox1.Text));
            var patterns = CollatzAgent.ExtractPattern(bi, 1, Math.Abs(patternlength));
            var bytes = CollatzAgent.ConvertpatternintoBytes(patterns, patternlength);
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(sv.FileName, bytes);
            }
        }
    }
}
