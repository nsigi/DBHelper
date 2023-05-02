using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Tables
{
    public partial class FormProgram : Form
    {
        public FormProgram()
        {
            InitializeComponent();
        }

        private void FormProgram_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.PROGRAM". При необходимости она может быть перемещена или удалена.
            this.pROGRAMTableAdapter.Fill(this.dataSet2.PROGRAM);

        }
    }
}
