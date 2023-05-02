using GemBox.Spreadsheet;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Tables;
using WindowsFormsApp1.Adding;
using WindowsFormsApp1.Updating;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Button curButton;
        private Form activeForm;
        Tables? curTable;
        Microsoft.Office.Interop.Excel.Application xlApp;
        Microsoft.Office.Interop.Excel.Worksheet xlSheet;
        Microsoft.Office.Interop.Excel.Range xlSheetRange;
        enum Tables
        {
            Participants,
            Papers,
            Section,
            Program,
            Award,
            View
        }
        public Form1()
        {
            InitializeComponent();
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.LAB9VIEW". При необходимости она может быть перемещена или удалена.
            this.lAB9VIEWTableAdapter.Fill(this.dataSet2.LAB9VIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.PARTICIPANTS". При необходимости она может быть перемещена или удалена.
            this.pARTICIPANTSTableAdapter.Fill(this.dataSet2.PARTICIPANTS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.Papers". При необходимости она может быть перемещена или удалена.
            this.papersTableAdapter.Fill(this.dataSet2.Papers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.AWARD". При необходимости она может быть перемещена или удалена.
            this.aWARDTableAdapter.Fill(this.dataSet2.AWARD);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SECTION". При необходимости она может быть перемещена или удалена.

        }

        private void CheckButton(object sender)
        {
            if (curButton == null)
            {
                ActivateButton(sender);
                curButton = sender as Button;
                SelectChildForm(sender);
            }
            else
            {
                if (curButton != sender)
                {
                    DisableButton(curButton);
                    DisableChildForm(activeForm);
                    ActivateButton(sender);
                    curButton = sender as Button;
                    SelectChildForm(sender);
                }
            }
        }

        private void ActivateButton(object sender)
        {
            curButton = sender as Button;
            curButton.BackColor = Color.DarkGreen;
            curButton.ForeColor = Color.Transparent;
        }

        private void DisableButton(object sender)
        {
            (sender as Button).BackColor = Color.DarkSeaGreen;
            (sender as Button).ForeColor = Color.Black;
            curButton = null;
        }

        private void SelectChildForm(object sender)
        {
            switch (curButton.TabIndex)
            {
                case (int)Tables.Participants:
                    {
                        OpenChildForm(new FormParticipants(), sender);
                        curTable = Tables.Participants;
                        break;
                    }
                case (int)Tables.Papers:
                    {
                        OpenChildForm(new FormPapers(), sender);
                        curTable = Tables.Papers;
                        break;
                    }
                case (int)Tables.Section:
                    {
                        OpenChildForm(new FormSection(), sender);
                        curTable = Tables.Section;
                        break;
                    }
                case (int)Tables.Program:
                    {
                        OpenChildForm(new FormProgram(), sender);
                        curTable = Tables.Program;
                        break;
                    }
                case (int)Tables.Award:
                    {
                        OpenChildForm(new FormAward(), sender);
                        curTable = Tables.Award;
                        break;
                    }
                case (int)Tables.View:
                    {
                        //OpenChildForm(new FormView(), sender);
                        curTable = Tables.View;
                        break;
                    }
            }
        }

        private void OpenChildForm(Form childForm, object sender)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(childForm);
            this.panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void DisableChildForm(Form childForm)
        {
            childForm.Close();
            activeForm = null;
            curTable = null;
        }
        private void buttonParticipants_Click(object sender, EventArgs e)
        {
            CheckButton(sender);
        }

        private void buttonPapers_Click(object sender, EventArgs e)
        {
            CheckButton(sender);
        }

        private void buttonSection_Click(object sender, EventArgs e)
        {
            CheckButton(sender);
        }

        private void buttonProgram_Click(object sender, EventArgs e)
        {
            CheckButton(sender);
        }

        private void buttonAward_Click(object sender, EventArgs e)
        {
            CheckButton(sender);
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            //LoadDataToExcel(lAB9VIEWTableAdapter.GetData());
            var workbook = new ExcelFile();
            DataTable dataTable = lAB9VIEWTableAdapter.GetData();

            ExcelWorksheet worksheet = workbook.Worksheets.Add(dataTable.TableName);
            var s = dataTable.TableName;
            // Insert DataTable to an Excel worksheet.
            worksheet.InsertDataTable(dataTable,
            new InsertDataTableOptions()
            {
                ColumnHeaders = true
            });


            workbook.Save("View to Excel.xlsx");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                switch (curTable)
                {
                    case Tables.Participants:
                        {
                            new AddParticipantForm(pARTICIPANTSTableAdapter).ShowDialog();
                            (activeForm as FormParticipants).UpdateDataGridView();
                            break;
                        }
                    case Tables.Papers:
                        {
                            new AddPaperForm(papersTableAdapter).ShowDialog();
                            (activeForm as FormPapers).UpdateDataGridView();
                            break;
                        }
                }
            }
            catch (ArgumentException) { }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(
                    String.Format("Ошибка выполнения запроса\r\n{0}", ex.Message),
                   "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                switch (curTable)
                {
                    case Tables.Participants:
                        {
                            var form = new UpdateParticipantForm(pARTICIPANTSTableAdapter,
                                (activeForm as FormParticipants).dataGridView1.SelectedRows[0]);
                            form.ShowDialog();
                            (activeForm as FormParticipants).UpdateDataGridView();
                            break;
                        }
                    case Tables.Papers:
                        {
                            var form = new UpdatePaperForm(papersTableAdapter,
                                (activeForm as FormPapers).dataGridView1.SelectedRows[0]);
                            form.ShowDialog();
                            (activeForm as FormPapers).UpdateDataGridView();
                            break;
                        }
                }
            }
            catch (ArgumentException) { }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(
                    string.Format("Ошибка выполнения запроса\r\n{0}", ex.Message),
                   "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                    string.Format("Некорректные данные\r\n{0}", ex.Message),
                   "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                switch (curTable)
                {
                    case Tables.Participants:
                        {
                            var curRow = (activeForm as FormParticipants).dataGridView1.SelectedRows[0];

                            var id = decimal.Parse(curRow.Cells[0].Value.ToString());
                            var fname = curRow.Cells[1].Value.ToString();
                            var AD = curRow.Cells[2].Value.ToString();
                            var POW = curRow.Cells[3].Value.ToString();
                            var pos = curRow.Cells[4].Value.ToString();
                            var citizen = curRow.Cells[5].Value.ToString();
                            var bdate = DateTime.Parse(curRow.Cells[6].Value.ToString());
                            pARTICIPANTSTableAdapter.DeleteQuery(id);

                            (activeForm as FormParticipants).UpdateDataGridView();
                            break;
                        }
                    case Tables.Papers:
                        {
                            var curRow = (activeForm as FormPapers).dataGridView1.SelectedRows[0];

                            var ID_R = decimal.Parse(curRow.Cells[0].Value.ToString());
                            var Title = curRow.Cells[1].Value.ToString();
                            var ID = decimal.Parse(curRow.Cells[2].Value.ToString());
                            var SectionName = decimal.Parse(curRow.Cells[3].Value.ToString());
                            var Sdate = DateTime.Parse(curRow.Cells[4].Value.ToString());
                            var Type = curRow.Cells[5].Value.ToString();

                            papersTableAdapter.DeleteQuery(ID_R);

                            (activeForm as FormPapers).UpdateDataGridView();
                            break;
                        }
                }
            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(
                    String.Format("Ошибка выполения запроса\r\n{0}", ex.Message),
                   "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(
                    String.Format("Нет данных\r\n{0}", ex.Message),
                   "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                switch (curTable)
                {
                    case Tables.Participants:
                        {
                            var curRow = (activeForm as FormParticipants).dataGridView1.SelectedRows[0];

                            var id = decimal.Parse(curRow.Cells[0].Value.ToString());
                            var fname = curRow.Cells[1].Value.ToString();
                            var AD = curRow.Cells[2].Value.ToString();
                            var POW = curRow.Cells[3].Value.ToString();
                            var pos = curRow.Cells[4].Value.ToString();
                            var citizen = curRow.Cells[5].Value.ToString();
                            var bdate = DateTime.Parse(curRow.Cells[6].Value.ToString());
                            pARTICIPANTSTableAdapter.DeleteQuery(id);

                            (activeForm as FormParticipants).UpdateDataGridView();
                            break;
                        }
                    case Tables.Papers:
                        {
                            var curRow = (activeForm as FormPapers).dataGridView1.SelectedRows[0];

                            var ID_R = decimal.Parse(curRow.Cells[0].Value.ToString());
                            var Title = curRow.Cells[1].Value.ToString();
                            var ID = decimal.Parse(curRow.Cells[2].Value.ToString());
                            var SectionName = decimal.Parse(curRow.Cells[3].Value.ToString());
                            var Sdate = DateTime.Parse(curRow.Cells[4].Value.ToString());
                            var Type = curRow.Cells[5].Value.ToString();

                            papersTableAdapter.DeleteQuery(ID_R);

                            (activeForm as FormPapers).UpdateDataGridView();
                            break;
                        }
                }
            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(
                    String.Format("Ошибка выполения запроса\r\n{0}", ex.Message),
                   "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(
                    String.Format("Нет данных\r\n{0}", ex.Message),
                   "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}