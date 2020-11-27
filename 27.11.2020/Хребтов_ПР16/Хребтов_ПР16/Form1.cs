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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                if (int.Parse(textBox1.Text) > int.Parse(textBox2.Text))
                {
                    label3.Text = "Это больше";
                    label4.Text = "Это меньше";
                }

                else if (int.Parse(textBox1.Text) < int.Parse(textBox2.Text))
                {
                    label3.Text = "Это меньше";
                    label4.Text = "Это больше";
                }

                else
                {
                    label3.Text = "Это равно";
                    label4.Text = "Это равно";
                }
            }

            else MessageBox.Show("Вы не ввели число(числа)", "Ошибка");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}
