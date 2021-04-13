using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Хребтов_ПР32
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            ToolStripMenuItem fasterMenuItem = new ToolStripMenuItem("Быстрее");
            ToolStripMenuItem slowerMenuItem = new ToolStripMenuItem("Медленнее");
            contextMenuStrip1.Items.AddRange(new[] { fasterMenuItem, slowerMenuItem });
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            fasterMenuItem.Click += fasterMenuItemClick;
            slowerMenuItem.Click += slowerMenuItemClick;
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            Hide();
        }

        private void fasterMenuItemClick(object sender, EventArgs e) 
        {
            timer1.Interval = timer1.Interval - 2;
            if (timer1.Interval > 10) timer1.Interval = timer1.Interval - 10;   
        }

        private void slowerMenuItemClick(object sender, EventArgs e) 
        {
            timer1.Interval = timer1.Interval + 2;
            if (timer1.Interval < 10) timer1.Interval = timer1.Interval + 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top > Height) pictureBox1.Top = -pictureBox1.Height;
            pictureBox1.Top = pictureBox1.Top + 1;   
        }
    }
}
