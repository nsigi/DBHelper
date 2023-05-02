namespace WindowsFormsApp1.Tables
{
    partial class FormView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicDegreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lAB9VIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new WindowsFormsApp1.DataSet2();
            this.lAB9VIEWTableAdapter = new WindowsFormsApp1.DataSet2TableAdapters.LAB9VIEWTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAB9VIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.academicDegreeDataGridViewTextBoxColumn,
            this.placeOfWorkDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.citizenshipDataGridViewTextBoxColumn,
            this.bdateDataGridViewTextBoxColumn,
            this.iDRDataGridViewTextBoxColumn,
            this.tITLEDataGridViewTextBoxColumn,
            this.sectionNameDataGridViewTextBoxColumn,
            this.sdateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lAB9VIEWBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 62;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fnameDataGridViewTextBoxColumn.Width = 95;
            // 
            // academicDegreeDataGridViewTextBoxColumn
            // 
            this.academicDegreeDataGridViewTextBoxColumn.DataPropertyName = "AcademicDegree";
            this.academicDegreeDataGridViewTextBoxColumn.HeaderText = "AcademicDegree";
            this.academicDegreeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.academicDegreeDataGridViewTextBoxColumn.Name = "academicDegreeDataGridViewTextBoxColumn";
            this.academicDegreeDataGridViewTextBoxColumn.ReadOnly = true;
            this.academicDegreeDataGridViewTextBoxColumn.Width = 168;
            // 
            // placeOfWorkDataGridViewTextBoxColumn
            // 
            this.placeOfWorkDataGridViewTextBoxColumn.DataPropertyName = "PlaceOfWork";
            this.placeOfWorkDataGridViewTextBoxColumn.HeaderText = "PlaceOfWork";
            this.placeOfWorkDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.placeOfWorkDataGridViewTextBoxColumn.Name = "placeOfWorkDataGridViewTextBoxColumn";
            this.placeOfWorkDataGridViewTextBoxColumn.ReadOnly = true;
            this.placeOfWorkDataGridViewTextBoxColumn.Width = 138;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 101;
            // 
            // citizenshipDataGridViewTextBoxColumn
            // 
            this.citizenshipDataGridViewTextBoxColumn.DataPropertyName = "Citizenship";
            this.citizenshipDataGridViewTextBoxColumn.HeaderText = "Citizenship";
            this.citizenshipDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.citizenshipDataGridViewTextBoxColumn.Name = "citizenshipDataGridViewTextBoxColumn";
            this.citizenshipDataGridViewTextBoxColumn.ReadOnly = true;
            this.citizenshipDataGridViewTextBoxColumn.Width = 122;
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "Bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "Bdate";
            this.bdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            this.bdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bdateDataGridViewTextBoxColumn.Width = 88;
            // 
            // iDRDataGridViewTextBoxColumn
            // 
            this.iDRDataGridViewTextBoxColumn.DataPropertyName = "ID_R";
            this.iDRDataGridViewTextBoxColumn.HeaderText = "ID_R";
            this.iDRDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDRDataGridViewTextBoxColumn.Name = "iDRDataGridViewTextBoxColumn";
            this.iDRDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRDataGridViewTextBoxColumn.Width = 83;
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            this.tITLEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tITLEDataGridViewTextBoxColumn.Width = 88;
            // 
            // sectionNameDataGridViewTextBoxColumn
            // 
            this.sectionNameDataGridViewTextBoxColumn.DataPropertyName = "SectionName";
            this.sectionNameDataGridViewTextBoxColumn.HeaderText = "SectionName";
            this.sectionNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sectionNameDataGridViewTextBoxColumn.Name = "sectionNameDataGridViewTextBoxColumn";
            this.sectionNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectionNameDataGridViewTextBoxColumn.Width = 141;
            // 
            // sdateDataGridViewTextBoxColumn
            // 
            this.sdateDataGridViewTextBoxColumn.DataPropertyName = "Sdate";
            this.sdateDataGridViewTextBoxColumn.HeaderText = "Sdate";
            this.sdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sdateDataGridViewTextBoxColumn.Name = "sdateDataGridViewTextBoxColumn";
            this.sdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sdateDataGridViewTextBoxColumn.Width = 88;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 79;
            // 
            // lAB9VIEWBindingSource
            // 
            this.lAB9VIEWBindingSource.DataMember = "LAB9VIEW";
            this.lAB9VIEWBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lAB9VIEWTableAdapter
            // 
            this.lAB9VIEWTableAdapter.ClearBeforeFill = true;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormView";
            this.Text = "FormView";
            this.Load += new System.EventHandler(this.FormView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAB9VIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource lAB9VIEWBindingSource;
        private DataSet2TableAdapters.LAB9VIEWTableAdapter lAB9VIEWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicDegreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
    }
}