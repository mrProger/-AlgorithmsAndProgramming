using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Хребтов_ПР36
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
    }
}
