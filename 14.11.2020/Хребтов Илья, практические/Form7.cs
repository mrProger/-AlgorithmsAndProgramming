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
    public partial class Form7 : Form
    {
        public int num;

        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            num = rand.Next(0, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;

            if (num == 0) MessageBox.Show("Число не сгенерировано!");
            else
            {
                if (textBox1.Text != "")
                {
                    a = int.Parse(textBox1.Text);

                    if (a == num) MessageBox.Show("Вы угадали!");
                    else MessageBox.Show("Вы не угадали!");
                }
                else MessageBox.Show("Вы забыли ввести число!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            this.Hide();
            form8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Было загадано - " + num.ToString());
            num = 0;
        }
    }
}
