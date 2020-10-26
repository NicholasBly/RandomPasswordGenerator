using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Password_Generator
{
    public partial class Form1 : Form
    {
        //string[] values = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        //int[] numbers = new [] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //string a = trackBar1.Value;
        public Form1()
        {
            InitializeComponent();
        }

        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public string CreatePasswordlower(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public string CreatePasswordupper(int length)
        {
            const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        public string CreatePassworduplow(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public string CreatePasswordlownum(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyz1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public string CreatePasswordupnum(int length)
        {
            const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public string CreatePasswordnumbersonly(int length)
        {
            const string valid = "1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Unchecked && checkBox3.CheckState == CheckState.Unchecked && checkBox4.CheckState == CheckState.Unchecked)//Nothing Selected
            {
                MessageBox.Show("You Must Select A CheckBox Below!");
            }
            else if (checkBox2.CheckState == CheckState.Unchecked && checkBox3.CheckState == CheckState.Checked && checkBox4.CheckState == CheckState.Unchecked)//lower case selected
            {
                textBox1.Text = CreatePasswordlower(trackBar1.Value);
            }
            else if (checkBox2.CheckState == CheckState.Checked && checkBox3.CheckState == CheckState.Unchecked && checkBox4.CheckState == CheckState.Unchecked)//upper case selected
            {
                textBox1.Text = CreatePasswordupper(trackBar1.Value);
            }
            else if (checkBox2.CheckState == CheckState.Checked && checkBox3.CheckState == CheckState.Checked && checkBox4.CheckState == CheckState.Checked)//Upper and LowerCase and numbers
            {
                textBox1.Text = CreatePassword(trackBar1.Value);
            }
            else if (checkBox2.CheckState == CheckState.Checked && checkBox3.CheckState == CheckState.Checked && checkBox4.CheckState == CheckState.Unchecked)//Upper and LowerCase
            {
                textBox1.Text = CreatePassworduplow(trackBar1.Value);
            }
            else if (checkBox2.CheckState == CheckState.Unchecked && checkBox3.CheckState == CheckState.Checked && checkBox4.CheckState == CheckState.Checked)//lower and num
            {
                textBox1.Text = CreatePasswordlownum(trackBar1.Value);
            }
            else if (checkBox2.CheckState == CheckState.Checked && checkBox3.CheckState == CheckState.Unchecked && checkBox4.CheckState == CheckState.Checked)//upper and num
            {
                textBox1.Text = CreatePasswordupnum(trackBar1.Value);
            }
            else if (checkBox2.CheckState == CheckState.Unchecked && checkBox3.CheckState == CheckState.Unchecked && checkBox4.CheckState == CheckState.Checked)//nums only
            {
                textBox1.Text = CreatePasswordnumbersonly(trackBar1.Value);
            }
            if (checkBox1.CheckState == CheckState.Checked)
            {
                Clipboard.SetText(textBox1.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
