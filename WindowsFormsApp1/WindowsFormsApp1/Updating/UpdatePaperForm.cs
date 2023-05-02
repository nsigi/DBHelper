using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataSet2TableAdapters;

namespace WindowsFormsApp1.Updating
{
    public partial class UpdatePaperForm : Form
    {
        PapersTableAdapter papersTableAdapter;
        public DataGridViewRow curRow;
        public UpdatePaperForm(PapersTableAdapter papersTableAdapter, DataGridViewRow curRow)
        {
            InitializeComponent();
            this.papersTableAdapter = papersTableAdapter;
            this.curRow = curRow;
            FillFormAndUpdate(curRow);
        }

        public void FillFormAndUpdate(DataGridViewRow curRow)
        {
            tbID_R.Text = decimal.Parse(curRow.Cells[0].Value.ToString()).ToString();
            tbTitle.Text = curRow.Cells[1].Value.ToString();
            tbID.Text = decimal.Parse(curRow.Cells[2].Value.ToString()).ToString();
            tbSectionName.Text = decimal.Parse(curRow.Cells[3].Value.ToString()).ToString();
            tbSdate.Text = curRow.Cells[4].Value.ToString();
            tbType.Text = curRow.Cells[5].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            papersTableAdapter.Update(
                decimal.Parse(tbID_R.Text),
                tbTitle.Text,
                decimal.Parse(tbID.Text),
                decimal.Parse(tbSectionName.Text),
                DateTime.Parse(tbSdate.Text),
                tbType.Text,
                //-------
                decimal.Parse(curRow.Cells[0].Value.ToString()),
                curRow.Cells[1].Value.ToString(),
                decimal.Parse(curRow.Cells[2].Value.ToString()),
                decimal.Parse(curRow.Cells[3].Value.ToString()),
                DateTime.Parse(curRow.Cells[4].Value.ToString()),
                curRow.Cells[5].Value.ToString()
                );
            Close();
        }
    }
}
