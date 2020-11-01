namespace GardenGroupUI
{
    partial class CurrentTickets
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
            this.listViewTickets = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReportedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.labelSort = new System.Windows.Forms.Label();
            this.textBoxDetailed = new System.Windows.Forms.TextBox();
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.btnNewTicket = new System.Windows.Forms.Button();
            this.label_ticketList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewTickets
            // 
            this.listViewTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderSubject,
            this.columnHeaderReportedBy,
            this.columnHeaderDate,
            this.columnHeaderPriority});
            this.listViewTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTickets.FullRowSelect = true;
            this.listViewTickets.HideSelection = false;
            this.listViewTickets.Location = new System.Drawing.Point(31, 103);
            this.listViewTickets.MultiSelect = false;
            this.listViewTickets.Name = "listViewTickets";
            this.listViewTickets.Size = new System.Drawing.Size(700, 385);
            this.listViewTickets.TabIndex = 2;
            this.listViewTickets.UseCompatibleStateImageBehavior = false;
            this.listViewTickets.View = System.Windows.Forms.View.Details;
            this.listViewTickets.SelectedIndexChanged += new System.EventHandler(this.listViewTickets_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 126;
            // 
            // columnHeaderSubject
            // 
            this.columnHeaderSubject.Text = "Subject";
            this.columnHeaderSubject.Width = 89;
            // 
            // columnHeaderReportedBy
            // 
            this.columnHeaderReportedBy.Text = "Reported By";
            this.columnHeaderReportedBy.Width = 174;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 162;
            // 
            // columnHeaderPriority
            // 
            this.columnHeaderPriority.Text = "Priority";
            this.columnHeaderPriority.Width = 101;
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.AllowDrop = true;
            this.comboBoxSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "Default",
            "Priority",
            "Date reported",
            "Deadline",
            "Solved"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(966, 100);
            this.comboBoxSortBy.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(112, 28);
            this.comboBoxSortBy.TabIndex = 6;
            this.comboBoxSortBy.Text = "Default";
            this.comboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortBy_SelectedIndexChanged);
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.labelSort.Location = new System.Drawing.Point(866, 103);
            this.labelSort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(59, 20);
            this.labelSort.TabIndex = 5;
            this.labelSort.Text = "Sort by";
            // 
            // textBoxDetailed
            // 
            this.textBoxDetailed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDetailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDetailed.Location = new System.Drawing.Point(760, 198);
            this.textBoxDetailed.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDetailed.Multiline = true;
            this.textBoxDetailed.Name = "textBoxDetailed";
            this.textBoxDetailed.ReadOnly = true;
            this.textBoxDetailed.Size = new System.Drawing.Size(358, 290);
            this.textBoxDetailed.TabIndex = 4;
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(156)))), ((int)(((byte)(208)))));
            this.btnUpdateTicket.Enabled = false;
            this.btnUpdateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTicket.Location = new System.Drawing.Point(760, 134);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(165, 59);
            this.btnUpdateTicket.TabIndex = 8;
            this.btnUpdateTicket.Text = "Update Ticket";
            this.btnUpdateTicket.UseVisualStyleBackColor = false;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // btnNewTicket
            // 
            this.btnNewTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(156)))), ((int)(((byte)(208)))));
            this.btnNewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTicket.Location = new System.Drawing.Point(966, 134);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(152, 59);
            this.btnNewTicket.TabIndex = 7;
            this.btnNewTicket.Text = "Create new Ticket";
            this.btnNewTicket.UseVisualStyleBackColor = false;
            this.btnNewTicket.Click += new System.EventHandler(this.btnNewTicket_Click);
            // 
            // label_ticketList
            // 
            this.label_ticketList.AutoSize = true;
            this.label_ticketList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ticketList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label_ticketList.Location = new System.Drawing.Point(70, 57);
            this.label_ticketList.Name = "label_ticketList";
            this.label_ticketList.Size = new System.Drawing.Size(122, 29);
            this.label_ticketList.TabIndex = 9;
            this.label_ticketList.Text = "Ticket List";
            // 
            // CurrentTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Controls.Add(this.label_ticketList);
            this.Controls.Add(this.btnUpdateTicket);
            this.Controls.Add(this.btnNewTicket);
            this.Controls.Add(this.comboBoxSortBy);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.textBoxDetailed);
            this.Controls.Add(this.listViewTickets);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CurrentTickets";
            this.Size = new System.Drawing.Size(1177, 602);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTickets;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderSubject;
        private System.Windows.Forms.ColumnHeader columnHeaderReportedBy;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderPriority;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.TextBox textBoxDetailed;
        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.Button btnNewTicket;
        private System.Windows.Forms.Label label_ticketList;
    }
}
