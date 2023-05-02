namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTables = new System.Windows.Forms.Panel();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAward = new System.Windows.Forms.Button();
            this.buttonProgram = new System.Windows.Forms.Button();
            this.buttonSection = new System.Windows.Forms.Button();
            this.buttonPapers = new System.Windows.Forms.Button();
            this.buttonParticipants = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet2 = new WindowsFormsApp1.DataSet2();
            this.aWARDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aWARDTableAdapter = new WindowsFormsApp1.DataSet2TableAdapters.AWARDTableAdapter();
            this.papersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.papersTableAdapter = new WindowsFormsApp1.DataSet2TableAdapters.PapersTableAdapter();
            this.pARTICIPANTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pARTICIPANTSTableAdapter = new WindowsFormsApp1.DataSet2TableAdapters.PARTICIPANTSTableAdapter();
            this.lAB9VIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lAB9VIEWTableAdapter = new WindowsFormsApp1.DataSet2TableAdapters.LAB9VIEWTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTables.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aWARDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPANTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAB9VIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelTables);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 676);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(344, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 676);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1317, 661);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(85, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(749, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выберите таблицу для просмотра";
            // 
            // panelTables
            // 
            this.panelTables.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelTables.Controls.Add(this.buttonView);
            this.panelTables.Controls.Add(this.buttonDelete);
            this.panelTables.Controls.Add(this.buttonEdit);
            this.panelTables.Controls.Add(this.buttonAdd);
            this.panelTables.Controls.Add(this.buttonAward);
            this.panelTables.Controls.Add(this.buttonProgram);
            this.panelTables.Controls.Add(this.buttonSection);
            this.panelTables.Controls.Add(this.buttonPapers);
            this.panelTables.Controls.Add(this.buttonParticipants);
            this.panelTables.Controls.Add(this.flowLayoutPanel1);
            this.panelTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTables.ForeColor = System.Drawing.Color.DarkOrange;
            this.panelTables.Location = new System.Drawing.Point(0, 0);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(344, 676);
            this.panelTables.TabIndex = 5;
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonView.FlatAppearance.BorderSize = 0;
            this.buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.ForeColor = System.Drawing.Color.Black;
            this.buttonView.Location = new System.Drawing.Point(0, 462);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(344, 59);
            this.buttonView.TabIndex = 5;
            this.buttonView.Text = "Report";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Tomato;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(261, 588);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(77, 68);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "-";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // buttonEdit
            // 
            this.buttonEdit.ForeColor = System.Drawing.Color.Silver;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.Location = new System.Drawing.Point(141, 588);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(77, 68);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(12, 588);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(77, 68);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAward
            // 
            this.buttonAward.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonAward.FlatAppearance.BorderSize = 0;
            this.buttonAward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAward.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAward.ForeColor = System.Drawing.Color.Black;
            this.buttonAward.Location = new System.Drawing.Point(0, 378);
            this.buttonAward.Name = "buttonAward";
            this.buttonAward.Size = new System.Drawing.Size(344, 59);
            this.buttonAward.TabIndex = 4;
            this.buttonAward.Text = "Award";
            this.buttonAward.UseVisualStyleBackColor = false;
            this.buttonAward.Click += new System.EventHandler(this.buttonAward_Click);
            // 
            // buttonProgram
            // 
            this.buttonProgram.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonProgram.FlatAppearance.BorderSize = 0;
            this.buttonProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProgram.ForeColor = System.Drawing.Color.Black;
            this.buttonProgram.Location = new System.Drawing.Point(0, 313);
            this.buttonProgram.Name = "buttonProgram";
            this.buttonProgram.Size = new System.Drawing.Size(344, 59);
            this.buttonProgram.TabIndex = 3;
            this.buttonProgram.Text = "Program";
            this.buttonProgram.UseVisualStyleBackColor = false;
            this.buttonProgram.Click += new System.EventHandler(this.buttonProgram_Click);
            // 
            // buttonSection
            // 
            this.buttonSection.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonSection.FlatAppearance.BorderSize = 0;
            this.buttonSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSection.ForeColor = System.Drawing.Color.Black;
            this.buttonSection.Location = new System.Drawing.Point(0, 248);
            this.buttonSection.Name = "buttonSection";
            this.buttonSection.Size = new System.Drawing.Size(344, 59);
            this.buttonSection.TabIndex = 2;
            this.buttonSection.Text = "Section";
            this.buttonSection.UseVisualStyleBackColor = false;
            this.buttonSection.Click += new System.EventHandler(this.buttonSection_Click);
            // 
            // buttonPapers
            // 
            this.buttonPapers.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonPapers.FlatAppearance.BorderSize = 0;
            this.buttonPapers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPapers.ForeColor = System.Drawing.Color.Black;
            this.buttonPapers.Location = new System.Drawing.Point(0, 183);
            this.buttonPapers.Name = "buttonPapers";
            this.buttonPapers.Size = new System.Drawing.Size(344, 59);
            this.buttonPapers.TabIndex = 1;
            this.buttonPapers.Text = "Papers";
            this.buttonPapers.UseVisualStyleBackColor = false;
            this.buttonPapers.Click += new System.EventHandler(this.buttonPapers_Click);
            // 
            // buttonParticipants
            // 
            this.buttonParticipants.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonParticipants.FlatAppearance.BorderSize = 0;
            this.buttonParticipants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParticipants.ForeColor = System.Drawing.Color.Black;
            this.buttonParticipants.Location = new System.Drawing.Point(0, 118);
            this.buttonParticipants.Name = "buttonParticipants";
            this.buttonParticipants.Size = new System.Drawing.Size(344, 59);
            this.buttonParticipants.TabIndex = 0;
            this.buttonParticipants.Text = "Participants";
            this.buttonParticipants.UseVisualStyleBackColor = false;
            this.buttonParticipants.Click += new System.EventHandler(this.buttonParticipants_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(378, 111);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 111);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tables";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aWARDBindingSource
            // 
            this.aWARDBindingSource.DataMember = "AWARD";
            this.aWARDBindingSource.DataSource = this.dataSet2;
            // 
            // aWARDTableAdapter
            // 
            this.aWARDTableAdapter.ClearBeforeFill = true;
            // 
            // papersBindingSource
            // 
            this.papersBindingSource.DataMember = "Papers";
            this.papersBindingSource.DataSource = this.dataSet2;
            // 
            // papersTableAdapter
            // 
            this.papersTableAdapter.ClearBeforeFill = true;
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
            // lAB9VIEWBindingSource
            // 
            this.lAB9VIEWBindingSource.DataMember = "LAB9VIEW";
            this.lAB9VIEWBindingSource.DataSource = this.dataSet2;
            // 
            // lAB9VIEWTableAdapter
            // 
            this.lAB9VIEWTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 676);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelTables.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aWARDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPANTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAB9VIEWBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTables;
        private System.Windows.Forms.Button buttonAward;
        private System.Windows.Forms.Button buttonProgram;
        private System.Windows.Forms.Button buttonSection;
        private System.Windows.Forms.Button buttonPapers;
        private System.Windows.Forms.Button buttonParticipants;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel3;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource aWARDBindingSource;
        private DataSet2TableAdapters.AWARDTableAdapter aWARDTableAdapter;
        private System.Windows.Forms.BindingSource papersBindingSource;
        private DataSet2TableAdapters.PapersTableAdapter papersTableAdapter;
        private System.Windows.Forms.BindingSource pARTICIPANTSBindingSource;
        private DataSet2TableAdapters.PARTICIPANTSTableAdapter pARTICIPANTSTableAdapter;
        private System.Windows.Forms.BindingSource lAB9VIEWBindingSource;
        private DataSet2TableAdapters.LAB9VIEWTableAdapter lAB9VIEWTableAdapter;
        private System.Windows.Forms.Label label2;
    }
}

