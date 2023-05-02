using System;
using System.Windows.Forms;
using WindowsFormsApp1.DataSet2TableAdapters;


namespace WindowsFormsApp1.Adding
{
    public partial class AddParticipantForm : Form
    {
        PARTICIPANTSTableAdapter pARTICIPANTSTableAdapter;
        public AddParticipantForm(PARTICIPANTSTableAdapter pARTICIPANTSTableAdapter)
        {
            InitializeComponent();
            this.pARTICIPANTSTableAdapter = pARTICIPANTSTableAdapter;
        }

        private void AddParticipantForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var ID = decimal.Parse(tbID.Text);
            var Fname = tbFname.Text;
            var AD = tbAD.Text;
            var POW = tbPOW.Text;
            var Position = tbPosition.Text;
            var Citizenship = tbCitizenship.Text;
            DateTime Bdate = DateTime.Parse(tbBdate.Text);
            pARTICIPANTSTableAdapter.Insert(ID, Fname, AD, POW, Position, Citizenship, Bdate);
            Close();
        }
    }
}
