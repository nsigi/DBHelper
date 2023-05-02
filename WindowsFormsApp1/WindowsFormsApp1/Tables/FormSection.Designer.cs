namespace WindowsFormsApp1.Tables
{
    partial class FormSection
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
            this.sECTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sECTIONTableAdapter = new WindowsFormsApp1.DataSet2TableAdapters.SECTIONTableAdapter();
            this.sECTIONNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECTIONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECTIONBindingSource)).BeginInit();
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
            this.sECTIONNUMDataGridViewTextBoxColumn,
            this.sECTIONNAMEDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sECTIONBindingSource;
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
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sECTIONBindingSource
            // 
            this.sECTIONBindingSource.DataMember = "SECTION";
            this.sECTIONBindingSource.DataSource = this.dataSet2;
            // 
            // sECTIONTableAdapter
            // 
            this.sECTIONTableAdapter.ClearBeforeFill = true;
            // 
            // sECTIONNUMDataGridViewTextBoxColumn
            // 
            this.sECTIONNUMDataGridViewTextBoxColumn.DataPropertyName = "SECTION_NUM";
            this.sECTIONNUMDataGridViewTextBoxColumn.HeaderText = "SECTION_NUM";
            this.sECTIONNUMDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sECTIONNUMDataGridViewTextBoxColumn.Name = "sECTIONNUMDataGridViewTextBoxColumn";
            this.sECTIONNUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.sECTIONNUMDataGridViewTextBoxColumn.Width = 160;
            // 
            // sECTIONNAMEDataGridViewTextBoxColumn
            // 
            this.sECTIONNAMEDataGridViewTextBoxColumn.DataPropertyName = "SECTION_NAME";
            this.sECTIONNAMEDataGridViewTextBoxColumn.HeaderText = "SECTION_NAME";
            this.sECTIONNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sECTIONNAMEDataGridViewTextBoxColumn.Name = "sECTIONNAMEDataGridViewTextBoxColumn";
            this.sECTIONNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sECTIONNAMEDataGridViewTextBoxColumn.Width = 170;
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            this.dESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRIPTIONDataGridViewTextBoxColumn.Width = 154;
            // 
            // FormSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSection";
            this.Text = "FormSection";
            this.Load += new System.EventHandler(this.FormSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sECTIONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource sECTIONBindingSource;
        private DataSet2TableAdapters.SECTIONTableAdapter sECTIONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECTIONNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECTIONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
    }
}