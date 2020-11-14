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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            MessageBox.Show("Практическая работа №15");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            if (num % 2 == 0) textBox2.Text = "Делится";
            else textBox2.Text = "Не делится";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            if (num % 3 == 0) textBox2.Text = "Делится";
            else textBox2.Text = "Не делится";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            if (num % 5 == 0) textBox2.Text = "Делится";
            else textBox2.Text = "Не делится";
        }
    }
}
