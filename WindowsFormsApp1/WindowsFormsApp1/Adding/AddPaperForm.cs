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

namespace WindowsFormsApp1.Adding
{
    public partial class AddPaperForm : Form
    {
        PapersTableAdapter PapersTableAdapter;
        public AddPaperForm(PapersTableAdapter PapersTableAdapter)
        {
            InitializeComponent();
            this.PapersTableAdapter =  PapersTableAdapter;
        }

        private void AddPaperForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var ID_R = decimal.Parse(tbID_R.Text);
            var Title = tbTtitle.Text;
            var ID = decimal.Parse(tbID.Text);
            var SectionName = decimal.Parse(tbSectionName.Text);
            DateTime Sdate = DateTime.Parse(tbSdate.Text);
            var Type = tbType.Text;
            PapersTableAdapter.Insert(ID_R, Title, ID, SectionName, Sdate, Type);
            Close();
        }
    }
}
