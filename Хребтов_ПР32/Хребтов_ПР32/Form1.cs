using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Хребтов_ПР32
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        { 
            pictureBox1.Width = 10;
            pictureBox2.Width = 10;
            pictureBox3.Width = 10;
            pictureBox4.Width = 10;
            pictureBox5.Width = 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Width < 50) pictureBox1.Width = pictureBox1.Width + 1;
            else
            {
                pictureBox1.Width = 10;
                pictureBox1.Top = rand.Next(0, Height);
                pictureBox1.Left = rand.Next(0, Width);
            }

            if (pictureBox2.Width < 50) pictureBox2.Width = pictureBox2.Width + 1;
            else
            {
                pictureBox2.Width = 10;
                pictureBox2.Top = rand.Next(0, Height);
                pictureBox2.Left = rand.Next(0, Width);
            }

            if (pictureBox3.Width < 50) pictureBox3.Width = pictureBox3.Width + 1;
            else
            {
                pictureBox3.Width = 10;
                pictureBox3.Top = rand.Next(0, Height);
                pictureBox3.Left = rand.Next(0, Width);
            }

            if (pictureBox4.Width < 50) pictureBox4.Width = pictureBox4.Width + 1;
            else
            {
                pictureBox4.Width = 10;
                pictureBox4.Top = rand.Next(0, Height);
                pictureBox4.Left = rand.Next(0, Width);
            }

            if (pictureBox5.Width < 50) pictureBox5.Width = pictureBox5.Width + 1;
            else
            {
                pictureBox5.Width = 10;
                pictureBox5.Top = rand.Next(0, Height);
                pictureBox5.Left = rand.Next(0, Width);
            }
        }

        private void далееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            Hide();
        }

    }
}
