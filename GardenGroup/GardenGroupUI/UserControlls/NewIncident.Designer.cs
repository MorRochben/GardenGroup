namespace GardenGroupUI.UserControlls
{
    partial class NewIncident
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateReported = new System.Windows.Forms.DateTimePicker();
            this.btnCreateIncident = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.cmbIncicentType = new System.Windows.Forms.ComboBox();
            this.txtReportingUser = new System.Windows.Forms.TextBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.numReportHour = new System.Windows.Forms.NumericUpDown();
            this.numReportMinute = new System.Windows.Forms.NumericUpDown();
            this.dateDeadline = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDeadLineError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numReportHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReportMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New Incident Ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date/Time reported";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject of incident";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type of incident";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reported by user";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Priority";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Deadline/follow up";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(467, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Description";
            // 
            // dateReported
            // 
            this.dateReported.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReported.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReported.Location = new System.Drawing.Point(58, 112);
            this.dateReported.Name = "dateReported";
            this.dateReported.Size = new System.Drawing.Size(238, 24);
            this.dateReported.TabIndex = 8;
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateIncident.Location = new System.Drawing.Point(585, 440);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(163, 51);
            this.btnCreateIncident.TabIndex = 9;
            this.btnCreateIncident.Text = "Create Incident Ticket";
            this.btnCreateIncident.UseVisualStyleBackColor = false;
            this.btnCreateIncident.Click += new System.EventHandler(this.btnCreateIncident_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(58, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 51);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(58, 298);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(361, 24);
            this.txtSubject.TabIndex = 11;
            // 
            // cmbIncicentType
            // 
            this.cmbIncicentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIncicentType.FormattingEnabled = true;
            this.cmbIncicentType.Location = new System.Drawing.Point(58, 236);
            this.cmbIncicentType.Name = "cmbIncicentType";
            this.cmbIncicentType.Size = new System.Drawing.Size(164, 26);
            this.cmbIncicentType.TabIndex = 12;
            // 
            // txtReportingUser
            // 
            this.txtReportingUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportingUser.Location = new System.Drawing.Point(58, 174);
            this.txtReportingUser.Name = "txtReportingUser";
            this.txtReportingUser.Size = new System.Drawing.Size(361, 24);
            this.txtReportingUser.TabIndex = 13;
            // 
            // cmbPriority
            // 
            this.cmbPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(255, 236);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(164, 26);
            this.cmbPriority.TabIndex = 14;
            // 
            // numReportHour
            // 
            this.numReportHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numReportHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numReportHour.Location = new System.Drawing.Point(311, 112);
            this.numReportHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numReportHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numReportHour.Name = "numReportHour";
            this.numReportHour.Size = new System.Drawing.Size(45, 24);
            this.numReportHour.TabIndex = 15;
            this.numReportHour.ValueChanged += new System.EventHandler(this.numReportHour_ValueChanged);
            // 
            // numReportMinute
            // 
            this.numReportMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numReportMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numReportMinute.Location = new System.Drawing.Point(373, 112);
            this.numReportMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numReportMinute.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numReportMinute.Name = "numReportMinute";
            this.numReportMinute.Size = new System.Drawing.Size(46, 24);
            this.numReportMinute.TabIndex = 16;
            this.numReportMinute.ValueChanged += new System.EventHandler(this.numReportMinute_ValueChanged);
            // 
            // dateDeadline
            // 
            this.dateDeadline.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDeadline.Location = new System.Drawing.Point(58, 358);
            this.dateDeadline.Name = "dateDeadline";
            this.dateDeadline.Size = new System.Drawing.Size(238, 24);
            this.dateDeadline.TabIndex = 17;
            this.dateDeadline.ValueChanged += new System.EventHandler(this.dateDeadline_ValueChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(470, 112);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(284, 270);
            this.txtDescription.TabIndex = 18;
            this.txtDescription.Text = "";
            // 
            // lblDeadLineError
            // 
            this.lblDeadLineError.AutoSize = true;
            this.lblDeadLineError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadLineError.ForeColor = System.Drawing.Color.Red;
            this.lblDeadLineError.Location = new System.Drawing.Point(55, 385);
            this.lblDeadLineError.Name = "lblDeadLineError";
            this.lblDeadLineError.Size = new System.Drawing.Size(353, 18);
            this.lblDeadLineError.TabIndex = 19;
            this.lblDeadLineError.Text = "Deadline needs to be a date later than the report date";
            // 
            // NewIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.Controls.Add(this.lblDeadLineError);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dateDeadline);
            this.Controls.Add(this.numReportMinute);
            this.Controls.Add(this.numReportHour);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.txtReportingUser);
            this.Controls.Add(this.cmbIncicentType);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateIncident);
            this.Controls.Add(this.dateReported);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewIncident";
            this.Size = new System.Drawing.Size(776, 533);
            ((System.ComponentModel.ISupportInitialize)(this.numReportHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReportMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateReported;
        private System.Windows.Forms.Button btnCreateIncident;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.ComboBox cmbIncicentType;
        private System.Windows.Forms.TextBox txtReportingUser;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.NumericUpDown numReportHour;
        private System.Windows.Forms.NumericUpDown numReportMinute;
        private System.Windows.Forms.DateTimePicker dateDeadline;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblDeadLineError;
    }
}
