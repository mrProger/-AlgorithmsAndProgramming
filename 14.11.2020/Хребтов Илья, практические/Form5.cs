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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = double.Parse(textBox1.Text);
            double pr = double.Parse(textBox2.Text);
            double srok = double.Parse(textBox3.Text);

            textBox4.Text = Convert.ToString(sum * (pr / 100) * (srok / 365));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.Show();
        }
    }
}
