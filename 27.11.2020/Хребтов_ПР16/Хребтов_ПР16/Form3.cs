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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "")) 
            {
                if (int.Parse(textBox1.Text) > int.Parse(textBox2.Text))
                {
                    string a = textBox2.Text;
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = a;
                }

                else if (int.Parse(textBox1.Text) < int.Parse(textBox2.Text)) 
                {
                    string a = textBox1.Text;
                    textBox1.Text = textBox2.Text;
                    textBox2.Text = a;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }
    }
}
