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
    public partial class FormPapers : Form
    {
        public FormPapers()
        {
            InitializeComponent();
        }

        private void FormPapers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.Papers". При необходимости она может быть перемещена или удалена.
            this.papersTableAdapter.Fill(this.dataSet2.Papers);

        }

        public void UpdateDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            papersTableAdapter.Fill(dataSet2.Papers);
            dataGridView1.DataSource = papersBindingSource;
        }
    }
}
