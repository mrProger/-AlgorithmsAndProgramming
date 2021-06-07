using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Хребтов__ПР36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void материнская_платаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.материнская_платаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Материнская_плата". При необходимости она может быть перемещена или удалена.
            this.материнская_платаTableAdapter.Fill(this.dBDataSet.Материнская_плата);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.материнская_платаTableAdapter.DDR3(this.dBDataSet.Материнская_плата);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.материнская_платаTableAdapter.DDR4(this.dBDataSet.Материнская_плата);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.материнская_платаTableAdapter._2MemorySlots(this.dBDataSet.Материнская_плата);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.материнская_платаTableAdapter._4MemorySlots(this.dBDataSet.Материнская_плата);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.материнская_платаTableAdapter._1PCI(this.dBDataSet.Материнская_плата);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.материнская_платаTableAdapter._2PCI(this.dBDataSet.Материнская_плата);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                this.материнская_платаTableAdapter.Price_2500(this.dBDataSet.Материнская_плата);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.материнская_платаTableAdapter.Price_3500(this.dBDataSet.Материнская_плата);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                this.материнская_платаTableAdapter.Price_5000(this.dBDataSet.Материнская_плата);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                this.материнская_платаTableAdapter.ClearAllQuery(this.dBDataSet.Материнская_плата);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}