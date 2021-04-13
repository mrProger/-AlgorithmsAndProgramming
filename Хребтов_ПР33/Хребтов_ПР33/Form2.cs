using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Хребтов_ПР33
{
    public partial class Form2 : Form
    {
        public int k;

        public Form2()
        {
            InitializeComponent();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void далееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (k == 0)
            {
                pictureBox1.ImageLocation = "чел2.png";
                k = 1;
            }
            else
            {
                pictureBox1.ImageLocation = "чел1.png";
                k = 0;
            }

            if (pictureBox1.Left > Width) pictureBox1.Left = -pictureBox1.Width;
            pictureBox1.Left = pictureBox1.Left + 6;
        }

        private void Form2_Load(object sender, EventArgs e) 
        { 
            k = 0; 
        }
    }
}
