using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Хребтов__ПР30
{
    public partial class Form2 : Form
    {
        string num_pict = string.Empty;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            num_pict = domainUpDown1.Text;
            pictureBox1.ImageLocation = num_pict + ".jpg";
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            num_pict = domainUpDown1.Text;
            pictureBox1.ImageLocation = num_pict + ".jpg";
        }
    }
}
