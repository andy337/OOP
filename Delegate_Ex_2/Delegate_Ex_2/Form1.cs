using System;
using System.Drawing;
using System.Windows.Forms;

namespace Delegate_Ex_2
{
    public partial class Form1 : Form
    {
        private bool isTrasparent = false;
        private bool isBackgroundGray = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isTrasparent)
            {
                Opacity = 1.00;
            }
            else
            {
                Opacity = 0.8;
            }
            isTrasparent = !isTrasparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isBackgroundGray)
            {
                BackColor = Color.Yellow;
            }
            else
            {
                BackColor = Color.Gray;
            }
            isBackgroundGray = !isBackgroundGray;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello Home.\n" +
                            "World заблокований з міркувань карантину");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\n" +
                            "і цього мене не позбавиш!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button4.Click += button1_Click;
            }
            else
            {
                button4.Click -= button1_Click;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button4.Click += button2_Click;
            }
            else
            {
                button4.Click -= button2_Click;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                button4.Click += button3_Click;
            }
            else
            {
                button4.Click -= button3_Click;
            }
        }
    }
}