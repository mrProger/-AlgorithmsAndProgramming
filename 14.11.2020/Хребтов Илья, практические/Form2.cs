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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void PreviousFormButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double rast = 1;
            double cena = 1;
            double potreb = 1;

            if (textBox1.Text != "") rast = double.Parse(textBox1.Text);
            if (textBox2.Text != "") cena = double.Parse(textBox2.Text);
            if (textBox3.Text != "") potreb = double.Parse(textBox3.Text);

            ResultOutput.Text = ((rast / 100) * cena * potreb).ToString();
        }

        private void NextFormButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }
    }
}
