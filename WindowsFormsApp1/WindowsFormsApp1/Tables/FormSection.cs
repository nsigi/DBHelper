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
    public partial class FormSection : Form
    {
        public FormSection()
        {
            InitializeComponent();
        }

        private void FormSection_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.SECTION". При необходимости она может быть перемещена или удалена.
            this.sECTIONTableAdapter.Fill(this.dataSet2.SECTION);

        }
    }
}
