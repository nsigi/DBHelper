namespace WindowsFormsApp1.Tables
{
    partial class FormParticipants
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
            this.dataSet2 = new WindowsFormsApp1.DataSet2();
            this.pARTICIPANTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pARTICIPANTSTableAdapter = new WindowsFormsApp1.DataSet2TableAdapters.PARTICIPANTSTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicDegreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPANTSBindingSource)).BeginInit();
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
            this.bdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pARTICIPANTSBindingSource;
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
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pARTICIPANTSBindingSource
            // 
            this.pARTICIPANTSBindingSource.DataMember = "PARTICIPANTS";
            this.pARTICIPANTSBindingSource.DataSource = this.dataSet2;
            // 
            // pARTICIPANTSTableAdapter
            // 
            this.pARTICIPANTSTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 62;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 95;
            // 
            // academicDegreeDataGridViewTextBoxColumn
            // 
            this.academicDegreeDataGridViewTextBoxColumn.DataPropertyName = "AcademicDegree";
            this.academicDegreeDataGridViewTextBoxColumn.HeaderText = "AcademicDegree";
            this.academicDegreeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.academicDegreeDataGridViewTextBoxColumn.Name = "academicDegreeDataGridViewTextBoxColumn";
            this.academicDegreeDataGridViewTextBoxColumn.Width = 168;
            // 
            // placeOfWorkDataGridViewTextBoxColumn
            // 
            this.placeOfWorkDataGridViewTextBoxColumn.DataPropertyName = "PlaceOfWork";
            this.placeOfWorkDataGridViewTextBoxColumn.HeaderText = "PlaceOfWork";
            this.placeOfWorkDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.placeOfWorkDataGridViewTextBoxColumn.Name = "placeOfWorkDataGridViewTextBoxColumn";
            this.placeOfWorkDataGridViewTextBoxColumn.Width = 138;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 101;
            // 
            // citizenshipDataGridViewTextBoxColumn
            // 
            this.citizenshipDataGridViewTextBoxColumn.DataPropertyName = "Citizenship";
            this.citizenshipDataGridViewTextBoxColumn.HeaderText = "Citizenship";
            this.citizenshipDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.citizenshipDataGridViewTextBoxColumn.Name = "citizenshipDataGridViewTextBoxColumn";
            this.citizenshipDataGridViewTextBoxColumn.Width = 122;
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "Bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "Bdate";
            this.bdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            this.bdateDataGridViewTextBoxColumn.Width = 88;
            // 
            // FormParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormParticipants";
            this.Text = "FormParticipants";
            this.Load += new System.EventHandler(this.FormParticipants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPANTSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource pARTICIPANTSBindingSource;
        private DataSet2TableAdapters.PARTICIPANTSTableAdapter pARTICIPANTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicDegreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
    }
}