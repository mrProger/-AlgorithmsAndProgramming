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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            this.Hide();
            form9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (int.Parse(textBox1.Text) == 6) count++;
            if (int.Parse(textBox2.Text) == 10) count++;
            if (int.Parse(textBox3.Text) == 42) count++;
            if (int.Parse(textBox4.Text) == 20) count++;
            if (int.Parse(textBox5.Text) == 54) count++;
            if (int.Parse(textBox6.Text) == 32) count++;
            if (int.Parse(textBox7.Text) == 63) count++;
            if (int.Parse(textBox8.Text) == 9) count++;

            switch (count) {
                case 8: MessageBox.Show("отлично "); break;
                case 7: MessageBox.Show("хорошо "); break;
                case 6: MessageBox.Show("хорошо "); break;
                case 5: MessageBox.Show("удовлетворительно "); break;
                case 4: MessageBox.Show("удовлетворительно "); break;
                default: MessageBox.Show("плохо "); break;
            }
        }
    }
}
