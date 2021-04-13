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
    public partial class Form4 : Form
    {
        int k = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            Hide();
        }

        private void далееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (k)
            {
                case 0: pictureBox1.ImageLocation = "11.bmp"; break;
                case 1: pictureBox1.ImageLocation = "12.bmp"; break;
                case 2: pictureBox1.ImageLocation = "13.bmp"; break;
                case 3: pictureBox1.ImageLocation = "14.bmp"; break;
                case 4: pictureBox1.ImageLocation = "15.bmp"; break;
                case 5: pictureBox1.ImageLocation = "16.bmp"; break;
                default: k = 0; break;
            }

            if (k == 5) k = 0;
            else k++;

        }
    }
}
