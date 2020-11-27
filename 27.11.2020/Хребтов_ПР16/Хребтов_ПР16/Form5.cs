using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Хребтов_ПР16
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
            Form6 form6 = new Form6();
            this.Hide();
            form6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "")) 
            {
                double c = 0;
                double s = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text)) / 10000;

                switch (comboBox1.SelectedIndex) 
                {
                    case 0: c = 650; break;
                    case 1: c = 450; break;
                    case 2: c = 300; break;
                }

                textBox3.Text = Convert.ToString(s * c);
            }

            else MessageBox.Show("Вы не ввели число(числа)", "Ошибка");
        }
    }
}
