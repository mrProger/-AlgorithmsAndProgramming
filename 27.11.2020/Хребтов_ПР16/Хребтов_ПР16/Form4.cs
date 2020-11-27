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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "")) 
            {
                double c = 1;
                double s = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text)) / 10000;

                if (radioButton1.Checked) c = 360;
                else if (radioButton2.Checked) c = 180;
                else MessageBox.Show("Вы не выбрали материал", "Ошибка");

                textBox3.Text = Convert.ToString(s * c);
            }

            else MessageBox.Show("Вы не ввели число(числа)", "Ошибка");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }
    }
}
