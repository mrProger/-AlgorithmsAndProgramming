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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ToolStripMenuItem fasterMenuItem1 = new ToolStripMenuItem("Быстрее");
            ToolStripMenuItem slowerMenuItem1 = new ToolStripMenuItem("Медленнее");
            ToolStripMenuItem fasterMenuItem2 = new ToolStripMenuItem("Быстрее");
            ToolStripMenuItem slowerMenuItem2 = new ToolStripMenuItem("Медленнее");

            contextMenuStrip1.Items.AddRange(new[] { fasterMenuItem1, slowerMenuItem1 });
            contextMenuStrip2.Items.AddRange(new[] { fasterMenuItem2, slowerMenuItem2 });

            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            pictureBox2.ContextMenuStrip = contextMenuStrip2;

            fasterMenuItem1.Click += fasterMenuItem1Click;
            slowerMenuItem1.Click += slowerMenuItem1Click;
            fasterMenuItem2.Click += fasterMenuItem2Click;
            slowerMenuItem2.Click += slowerMenuItem2Click;
        }

        private void далееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            Hide();
        }

        private void fasterMenuItem1Click(object sender, EventArgs e) 
        {
            timer1.Interval = timer1.Interval - 2;
            if (timer1.Interval > 10) timer1.Interval = timer1.Interval - 10;   
        }

        private void slowerMenuItem1Click(object sender, EventArgs e) 
        {
            timer1.Interval = timer1.Interval + 2;
            if (timer1.Interval < 10) timer1.Interval = timer1.Interval + 10;
        }

        private void fasterMenuItem2Click(object sender, EventArgs e) 
        {
            timer2.Interval = timer2.Interval - 2;
            if (timer2.Interval > 10) timer2.Interval = timer2.Interval - 10;   
        }

        private void slowerMenuItem2Click(object sender, EventArgs e) 
        {
            timer2.Interval = timer2.Interval + 2;
            if (timer2.Interval < 10) timer2.Interval = timer2.Interval + 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left < 0 - pictureBox1.Width) pictureBox1.Left = Width + pictureBox1.Width - 80;
            pictureBox1.Left = pictureBox1.Left - 20;  
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Left > Width) pictureBox2.Left = -pictureBox2.Width;
            pictureBox2.Left = pictureBox2.Left + 20;
        }
    }
}
