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
    public partial class UpdateParticipantForm : Form
    {
        PARTICIPANTSTableAdapter pARTICIPANTSTableAdapter;
        public DataGridViewRow curRow;
        public UpdateParticipantForm(PARTICIPANTSTableAdapter pARTICIPANTSTableAdapter, DataGridViewRow curRow)
        {
            InitializeComponent();
            this.pARTICIPANTSTableAdapter = pARTICIPANTSTableAdapter;
            this.curRow = curRow;
            FillFormAndUpdate(curRow);
        }

        public void FillFormAndUpdate(DataGridViewRow curRow)
        {
            tbID.Text = decimal.Parse(curRow.Cells[0].Value.ToString()).ToString();
            tbFname.Text = curRow.Cells[1].Value.ToString();
            tbAD.Text = curRow.Cells[2].Value.ToString();
            tbPOW.Text = curRow.Cells[3].Value.ToString();
            tbPosition.Text = curRow.Cells[4].Value.ToString();
            tbCitizenship.Text = curRow.Cells[5].Value.ToString();
            tbBdate.Text = curRow.Cells[6].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pARTICIPANTSTableAdapter.Update(
                decimal.Parse(tbID.Text),
                tbFname.Text,
                tbAD.Text,
                tbPOW.Text,
                tbPosition.Text,
                tbCitizenship.Text,
                DateTime.Parse(tbBdate.Text),
                //------------------------
                decimal.Parse(curRow.Cells[0].Value.ToString()),
                curRow.Cells[1].Value.ToString(),
                curRow.Cells[2].Value.ToString(),
                curRow.Cells[3].Value.ToString(),
                curRow.Cells[4].Value.ToString(),
                curRow.Cells[5].Value.ToString(),
                DateTime.Parse(curRow.Cells[6].Value.ToString())
                );
            Close();
        }
    }
}
