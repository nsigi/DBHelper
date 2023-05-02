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
    public partial class FormParticipants : Form
    {
        public FormParticipants()
        {
            InitializeComponent();
        }

        private void FormParticipants_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.PARTICIPANTS". При необходимости она может быть перемещена или удалена.
            this.pARTICIPANTSTableAdapter.Fill(this.dataSet2.PARTICIPANTS);
        }

        public void UpdateDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            pARTICIPANTSTableAdapter.Fill(dataSet2.PARTICIPANTS);
            dataGridView1.DataSource = pARTICIPANTSBindingSource;
        }
    }
}
