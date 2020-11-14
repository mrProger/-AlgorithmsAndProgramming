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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Практическая работа №14");
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            FirstDegreeOutput.Text = "";
            SecondDegreeOutput.Text = "";
            ThirdDegreeOutput.Text = "";
            FourthDegreeOutput.Text = "";
            FifthDegreeOutput.Text = "";
        }

        private void FirstDegreeButton_Click(object sender, EventArgs e)
        {
            FirstDegreeOutput.Text = Math.Pow(2, 1).ToString();
        }

        private void SecondDegreeButton_Click(object sender, EventArgs e)
        {
            SecondDegreeOutput.Text = Math.Pow(2, 2).ToString();
        }

        private void ThirdDegreeButton_Click(object sender, EventArgs e)
        {
            ThirdDegreeOutput.Text = Math.Pow(2, 3).ToString();
        }

        private void FourthDegreeButton_Click(object sender, EventArgs e)
        {
            FourthDegreeOutput.Text = Math.Pow(2, 4).ToString();
        }

        private void FifthDegreeButton_Click(object sender, EventArgs e)
        {
            FifthDegreeOutput.Text = Math.Pow(2, 5).ToString();
        }

        private void NextFormButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}
