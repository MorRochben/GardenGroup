namespace GardenGroupUI.UserControlls
{
    partial class UpdateTicket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.cmbIncicentType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDeadLineError = new System.Windows.Forms.Label();
            this.dateDeadline = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblReportDate = new System.Windows.Forms.Label();
            this.cheSolved = new System.Windows.Forms.CheckBox();
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Reported by user: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date/Time reported: ";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(62, 50);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(361, 24);
            this.txtSubject.TabIndex = 13;
            this.txtSubject.TextChanged += new System.EventHandler(this.txtSubject_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Subject of incident";
            // 
            // cmbPriority
            // 
            this.cmbPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(62, 226);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(164, 26);
            this.cmbPriority.TabIndex = 18;
            this.cmbPriority.SelectedIndexChanged += new System.EventHandler(this.cmbPriority_SelectedIndexChanged);
            // 
            // cmbIncicentType
            // 
            this.cmbIncicentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIncicentType.FormattingEnabled = true;
            this.cmbIncicentType.Location = new System.Drawing.Point(62, 168);
            this.cmbIncicentType.Name = "cmbIncicentType";
            this.cmbIncicentType.Size = new System.Drawing.Size(164, 26);
            this.cmbIncicentType.TabIndex = 17;
            this.cmbIncicentType.SelectedIndexChanged += new System.EventHandler(this.cmbIncicentType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Priority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Type of incident";
            // 
            // lblDeadLineError
            // 
            this.lblDeadLineError.AutoSize = true;
            this.lblDeadLineError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadLineError.ForeColor = System.Drawing.Color.Red;
            this.lblDeadLineError.Location = new System.Drawing.Point(59, 308);
            this.lblDeadLineError.Name = "lblDeadLineError";
            this.lblDeadLineError.Size = new System.Drawing.Size(353, 18);
            this.lblDeadLineError.TabIndex = 22;
            this.lblDeadLineError.Text = "Deadline needs to be a date later than the report date";
            // 
            // dateDeadline
            // 
            this.dateDeadline.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDeadline.Location = new System.Drawing.Point(62, 281);
            this.dateDeadline.Name = "dateDeadline";
            this.dateDeadline.Size = new System.Drawing.Size(238, 24);
            this.dateDeadline.TabIndex = 21;
            this.dateDeadline.ValueChanged += new System.EventHandler(this.dateDeadline_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Deadline/follow up";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(496, 50);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(243, 316);
            this.txtDescription.TabIndex = 24;
            this.txtDescription.Text = "";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(493, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Description";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(206, 86);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 18);
            this.lblUsername.TabIndex = 26;
            this.lblUsername.Text = "username";
            // 
            // lblReportDate
            // 
            this.lblReportDate.AutoSize = true;
            this.lblReportDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportDate.Location = new System.Drawing.Point(206, 117);
            this.lblReportDate.Name = "lblReportDate";
            this.lblReportDate.Size = new System.Drawing.Size(80, 18);
            this.lblReportDate.TabIndex = 25;
            this.lblReportDate.Text = "00/00/0000";
            // 
            // cheSolved
            // 
            this.cheSolved.AutoSize = true;
            this.cheSolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheSolved.Location = new System.Drawing.Point(62, 344);
            this.cheSolved.Name = "cheSolved";
            this.cheSolved.Size = new System.Drawing.Size(72, 22);
            this.cheSolved.TabIndex = 28;
            this.cheSolved.Text = "Solved";
            this.cheSolved.UseVisualStyleBackColor = true;
            this.cheSolved.CheckedChanged += new System.EventHandler(this.cheSolved_CheckedChanged);
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTicket.Location = new System.Drawing.Point(576, 430);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(163, 51);
            this.btnUpdateTicket.TabIndex = 29;
            this.btnUpdateTicket.Text = "Update Incident Ticket";
            this.btnUpdateTicket.UseVisualStyleBackColor = false;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(62, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 51);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UpdateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateTicket);
            this.Controls.Add(this.cheSolved);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblReportDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDeadLineError);
            this.Controls.Add(this.dateDeadline);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.cmbIncicentType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "UpdateTicket";
            this.Size = new System.Drawing.Size(1055, 537);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.ComboBox cmbIncicentType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDeadLineError;
        private System.Windows.Forms.DateTimePicker dateDeadline;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblReportDate;
        private System.Windows.Forms.CheckBox cheSolved;
        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.Button btnCancel;
    }
}
