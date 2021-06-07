using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Хребтов__ПР31
{
    public partial class Form1 : Form
    {
        string num_pict;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            num_pict = domainUpDown1.Text;
            pictureBox1.ImageLocation = num_pict + ".jpg";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            num_pict = domainUpDown1.Text;
            pictureBox1.ImageLocation = num_pict + ".jpg";


        }

        private void наВесьЭкранToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

        }

        private void вернутьРазмерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (num_pict != "4")
            {
                n = int.Parse(num_pict);
                n++;
                num_pict = n.ToString();
                pictureBox1.ImageLocation = num_pict + ".jpg";
            }
            else
            {
                num_pict = "1";
                pictureBox1.ImageLocation = num_pict + ".jpg";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n;
            if (num_pict != "1")
            {
                n = int.Parse(num_pict);
                n--;
                num_pict = n.ToString();
                pictureBox1.ImageLocation = num_pict + ".jpg";
            }
            else
            {
                num_pict = "4";
                pictureBox1.ImageLocation = num_pict + ".jpg";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(num_pict);
            if (n == 4)	//если был 4-й рисунок, начинаем сначала
            { n = 0; }
            n++;
            num_pict = n.ToString();
            pictureBox1.ImageLocation = num_pict + ".jpg";

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
