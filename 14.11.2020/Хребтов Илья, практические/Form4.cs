using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Хребтов_Илья__практические
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = double.Parse(textBox1.Text);
            double h = double.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(3.14 * Math.Pow(r, 2) * h);
            textBox4.Text = Convert.ToString(((2 * 3.14) * r) * (h + r));
        }
    }
}
