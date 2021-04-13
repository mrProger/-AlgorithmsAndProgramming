using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Хребтов_ПР33
{
    public partial class Form3 : Form
    {
        bool k = false;
        bool i = false;

        public Form3()
        {
            InitializeComponent();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            Hide();
        }

        private void далееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            pictureBox1.ImageLocation = !k ? "3.bmp" : "4.bmp";
            k = !k;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            pictureBox2.ImageLocation = !i ? "2.bmp" : "1.bmp";
            i = !i;
        }
    }
}
