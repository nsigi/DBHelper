﻿namespace WindowsFormsApp1.Adding
{
    partial class AddParticipantForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCitizenship = new System.Windows.Forms.Label();
            this.tbCitizenship = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.lblAD = new System.Windows.Forms.Label();
            this.tbPOW = new System.Windows.Forms.TextBox();
            this.lblPOW = new System.Windows.Forms.Label();
            this.tbAD = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.labelBdate = new System.Windows.Forms.Label();
            this.tbBdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // brnCancel
            // 
            this.brnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.brnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brnCancel.Location = new System.Drawing.Point(357, 399);
            this.brnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brnCancel.Name = "brnCancel";
            this.brnCancel.Size = new System.Drawing.Size(176, 51);
            this.brnCancel.TabIndex = 39;
            this.brnCancel.Text = "Отменить";
            this.brnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(91, 399);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 51);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCitizenship
            // 
            this.lblCitizenship.AutoSize = true;
            this.lblCitizenship.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCitizenship.Location = new System.Drawing.Point(25, 284);
            this.lblCitizenship.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCitizenship.Name = "lblCitizenship";
            this.lblCitizenship.Size = new System.Drawing.Size(108, 25);
            this.lblCitizenship.TabIndex = 37;
            this.lblCitizenship.Text = "Citizenship";
            // 
            // tbCitizenship
            // 
            this.tbCitizenship.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCitizenship.Location = new System.Drawing.Point(196, 278);
            this.tbCitizenship.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCitizenship.Name = "tbCitizenship";
            this.tbCitizenship.Size = new System.Drawing.Size(372, 35);
            this.tbCitizenship.TabIndex = 36;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPosition.Location = new System.Drawing.Point(26, 234);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(81, 25);
            this.lblPosition.TabIndex = 35;
            this.lblPosition.Text = "Position";
            // 
            // tbPosition
            // 
            this.tbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPosition.Location = new System.Drawing.Point(196, 228);
            this.tbPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(372, 35);
            this.tbPosition.TabIndex = 34;
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAD.Location = new System.Drawing.Point(25, 136);
            this.lblAD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(163, 25);
            this.lblAD.TabIndex = 33;
            this.lblAD.Text = "AcademicDegree";
            // 
            // tbPOW
            // 
            this.tbPOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPOW.Location = new System.Drawing.Point(196, 179);
            this.tbPOW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPOW.Name = "tbPOW";
            this.tbPOW.Size = new System.Drawing.Size(372, 35);
            this.tbPOW.TabIndex = 32;
            // 
            // lblPOW
            // 
            this.lblPOW.AutoSize = true;
            this.lblPOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPOW.Location = new System.Drawing.Point(25, 189);
            this.lblPOW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPOW.Name = "lblPOW";
            this.lblPOW.Size = new System.Drawing.Size(129, 25);
            this.lblPOW.TabIndex = 31;
            this.lblPOW.Text = "PlaceOfWork";
            // 
            // tbAD
            // 
            this.tbAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAD.Location = new System.Drawing.Point(196, 130);
            this.tbAD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAD.Name = "tbAD";
            this.tbAD.Size = new System.Drawing.Size(372, 35);
            this.tbAD.TabIndex = 30;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFname.Location = new System.Drawing.Point(26, 87);
            this.lblFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(73, 25);
            this.lblFname.TabIndex = 29;
            this.lblFname.Text = "Fname";
            // 
            // tbFname
            // 
            this.tbFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFname.Location = new System.Drawing.Point(196, 81);
            this.tbFname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(372, 35);
            this.tbFname.TabIndex = 28;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblID.Location = new System.Drawing.Point(26, 37);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 25);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbID.Location = new System.Drawing.Point(196, 31);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(372, 35);
            this.tbID.TabIndex = 26;
            // 
            // labelBdate
            // 
            this.labelBdate.AutoSize = true;
            this.labelBdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBdate.Location = new System.Drawing.Point(26, 333);
            this.labelBdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBdate.Name = "labelBdate";
            this.labelBdate.Size = new System.Drawing.Size(63, 25);
            this.labelBdate.TabIndex = 41;
            this.labelBdate.Text = "Bdate";
            // 
            // tbBdate
            // 
            this.tbBdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBdate.Location = new System.Drawing.Point(196, 327);
            this.tbBdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBdate.Name = "tbBdate";
            this.tbBdate.Size = new System.Drawing.Size(372, 35);
            this.tbBdate.TabIndex = 40;
            // 
            // AddParticipantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 476);
            this.Controls.Add(this.labelBdate);
            this.Controls.Add(this.tbBdate);
            this.Controls.Add(this.brnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCitizenship);
            this.Controls.Add(this.tbCitizenship);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.lblAD);
            this.Controls.Add(this.tbPOW);
            this.Controls.Add(this.lblPOW);
            this.Controls.Add(this.tbAD);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbID);
            this.Name = "AddParticipantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddParticipantForm";
            this.Load += new System.EventHandler(this.AddParticipantForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCitizenship;
        private System.Windows.Forms.TextBox tbCitizenship;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.TextBox tbPOW;
        private System.Windows.Forms.Label lblPOW;
        private System.Windows.Forms.TextBox tbAD;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label labelBdate;
        private System.Windows.Forms.TextBox tbBdate;
    }
}