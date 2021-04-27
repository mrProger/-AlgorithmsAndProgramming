using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Хребтов_ПР35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tanksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tanksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tanksTableAdapter.Fill(this.bD1DataSet.tanks);
            pictureBox1.ImageLocation = "Танки/Фото/" + фотоTextBox.Text;
            richTextBox1.Text = File.ReadAllText("Танки/Описание/" + описаниеTextBox.Text, Encoding.Default);

        }

        private void tanksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.ImageLocation = "Танки/Фото/" + фотоTextBox.Text;
            richTextBox1.Text = File.ReadAllText("Танки/Описание/" + описаниеTextBox.Text, Encoding.Default);
        }

    }
}
