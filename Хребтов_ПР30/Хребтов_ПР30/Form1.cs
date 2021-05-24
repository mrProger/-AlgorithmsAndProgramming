using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Михайлов_Шемяков
{
    public partial class Form1 : Form
    {
        string[] model = { "WD Blue", "WD Green", "WD Red", "WD Black" };
        string[] opisan = { "", "", "", "" };
        string[] artikul = { "123", "231", "321", "144" };
        string[] pict = { "1.jpg", "2.jpg", "3.jpg", "4.jpg" };
        string[] cena = { "1550", "3480", "1550", "3480" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                comboBox1.Items.Add(model[i]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = comboBox1.SelectedIndex; // запоминаем номер выбранного элемента
            label3.Text = cena[n];      // выводим информацию об этом элементе
            label5.Text = artikul[n];
            label7.Text = opisan[n];
            pictureBox1.ImageLocation = pict[n];

        }

        private void ценаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void модельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void заполнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                comboBox1.Items.Add(model[i]);
        }

        private void увеличитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

        }

        private void уменьшитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();    // Скрываем текущую форму
            Form2 f = new Form2();
            f.Show();      // Открываем 2-ю форму


        }
    }
}
