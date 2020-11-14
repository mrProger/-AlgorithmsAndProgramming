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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            this.Hide();
            form8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double rost = double.Parse(textBox1.Text) / 100;
            double ves = double.Parse(textBox2.Text);
            double res = ves / (rost * rost);

            if (radioButton1.Checked) {
                if ((res >= 19) && (res <= 25)) MessageBox.Show("Вес нормальный");
                else MessageBox.Show("Вес не нормальный");
            }

            if (radioButton2.Checked) {
                if ((res >= 14) && (res <= 19)) MessageBox.Show("Вес нормальный");
                else MessageBox.Show("Вес не нормальный");
            }
        }
    }
}
