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
    public partial class Form5 : Form
    {
        int dx = 12;
        int dy = 40;

        public Form5()
        {
            InitializeComponent();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            Hide();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
              case Keys.Up: dy += -20; break;
              case Keys.Down: dy += +20; break;
              case Keys.Right: dx += 20; break;
              case Keys.Left: dx += -20; break;
              case Keys.W: dy += -20; break;
              case Keys.S: dy += +20; break;
              case Keys.D: dx += 20; break;
              case Keys.A: dx += -20; break;
              default: break;
            }
            pictureBox1.Location = new Point(dx, dy);
        }
    }
}
