namespace WindowsFormsApp1.Updating
{
    partial class UpdatePaperForm
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
            this.brnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.lblSdate = new System.Windows.Forms.Label();
            this.tbSdate = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.tbSectionName = new System.Windows.Forms.TextBox();
            this.lblSectionName = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblID_R = new System.Windows.Forms.Label();
            this.tbID_R = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // brnCancel
            // 
            this.brnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.brnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brnCancel.Location = new System.Drawing.Point(419, 355);
            this.brnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brnCancel.Name = "brnCancel";
            this.brnCancel.Size = new System.Drawing.Size(176, 51);
            this.brnCancel.TabIndex = 39;
            this.brnCancel.Text = "Отменить";
            this.brnCancel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(153, 355);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(170, 51);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.Location = new System.Drawing.Point(92, 285);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(68, 29);
            this.lblType.TabIndex = 37;
            this.lblType.Text = "Type";
            // 
            // tbType
            // 
            this.tbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbType.Location = new System.Drawing.Point(252, 282);
            this.tbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(372, 35);
            this.tbType.TabIndex = 36;
            // 
            // lblSdate
            // 
            this.lblSdate.AutoSize = true;
            this.lblSdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSdate.Location = new System.Drawing.Point(90, 235);
            this.lblSdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSdate.Name = "lblSdate";
            this.lblSdate.Size = new System.Drawing.Size(76, 29);
            this.lblSdate.TabIndex = 35;
            this.lblSdate.Text = "Sdate";
            // 
            // tbSdate
            // 
            this.tbSdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSdate.Location = new System.Drawing.Point(252, 232);
            this.tbSdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSdate.Name = "tbSdate";
            this.tbSdate.Size = new System.Drawing.Size(372, 35);
            this.tbSdate.TabIndex = 34;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblID.Location = new System.Drawing.Point(90, 137);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 29);
            this.lblID.TabIndex = 33;
            this.lblID.Text = "ID";
            // 
            // tbSectionName
            // 
            this.tbSectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSectionName.Location = new System.Drawing.Point(252, 183);
            this.tbSectionName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSectionName.Name = "tbSectionName";
            this.tbSectionName.Size = new System.Drawing.Size(372, 35);
            this.tbSectionName.TabIndex = 32;
            // 
            // lblSectionName
            // 
            this.lblSectionName.AutoSize = true;
            this.lblSectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSectionName.Location = new System.Drawing.Point(90, 186);
            this.lblSectionName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSectionName.Name = "lblSectionName";
            this.lblSectionName.Size = new System.Drawing.Size(159, 29);
            this.lblSectionName.TabIndex = 31;
            this.lblSectionName.Text = "SectionName";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbID.Location = new System.Drawing.Point(252, 134);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(372, 35);
            this.tbID.TabIndex = 30;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(90, 88);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 29);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Title";
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTitle.Location = new System.Drawing.Point(252, 85);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(372, 35);
            this.tbTitle.TabIndex = 28;
            // 
            // lblID_R
            // 
            this.lblID_R.AutoSize = true;
            this.lblID_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblID_R.Location = new System.Drawing.Point(92, 38);
            this.lblID_R.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID_R.Name = "lblID_R";
            this.lblID_R.Size = new System.Drawing.Size(66, 29);
            this.lblID_R.TabIndex = 27;
            this.lblID_R.Text = "ID_R";
            // 
            // tbID_R
            // 
            this.tbID_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbID_R.Location = new System.Drawing.Point(252, 35);
            this.tbID_R.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbID_R.Name = "tbID_R";
            this.tbID_R.Size = new System.Drawing.Size(372, 35);
            this.tbID_R.TabIndex = 26;
            // 
            // UpdatePaperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.brnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.lblSdate);
            this.Controls.Add(this.tbSdate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbSectionName);
            this.Controls.Add(this.lblSectionName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblID_R);
            this.Controls.Add(this.tbID_R);
            this.Name = "UpdatePaperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdatePaperForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label lblSdate;
        private System.Windows.Forms.TextBox tbSdate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbSectionName;
        private System.Windows.Forms.Label lblSectionName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblID_R;
        private System.Windows.Forms.TextBox tbID_R;
    }
}