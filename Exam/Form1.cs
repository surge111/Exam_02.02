using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        private string captcha;
        public Form1()
        {
            InitializeComponent();
        }

        private void SetCaptcha()
        {
            var alpha = "QWERTYUIOPASDFGHJKLZXCVBNM" +
                "qwertyuiopasdfghjklzxcvbnm" +
                "1234567890";
            captcha = "";
            var rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                captcha += alpha[rnd.Next(alpha.Length)];
            }
            label4.Text = captcha[0].ToString();
            label5.Text = captcha[1].ToString();
            label6.Text = captcha[2].ToString();
            label7.Text = captcha[3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "user" && textBox2.Text == "user")
            {

            }
            else
            {
                SetCaptcha();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetCaptcha();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = (textBox1.Text.Length == 0);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label9.Visible = (textBox2.Text.Length == 0);
        }
    }
}
