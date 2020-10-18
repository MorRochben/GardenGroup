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
            this.columnHeaderUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.labelSort = new System.Windows.Forms.Label();
            this.textBoxDetailed = new System.Windows.Forms.TextBox();
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.btnNewTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewTickets
            // 
            this.listViewTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderSubject,
            this.columnHeaderUser,
            this.columnHeaderDate,
            this.columnHeaderPriority});
            this.listViewTickets.FullRowSelect = true;
            this.listViewTickets.HideSelection = false;
            this.listViewTickets.Location = new System.Drawing.Point(31, 40);
            this.listViewTickets.MultiSelect = false;
            this.listViewTickets.Name = "listViewTickets";
            this.listViewTickets.Size = new System.Drawing.Size(543, 385);
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
            // columnHeaderUser
            // 
            this.columnHeaderUser.Text = "User";
            this.columnHeaderUser.Width = 174;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 162;
            // 
            // columnHeaderPriority
            // 
            this.columnHeaderPriority.Text = "Priotity";
            this.columnHeaderPriority.Width = 101;
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.AllowDrop = true;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "Default",
            "Priority",
            "Date reported",
            "Deadline",
            "Solved"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(735, 37);
            this.comboBoxSortBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(112, 21);
            this.comboBoxSortBy.TabIndex = 6;
            this.comboBoxSortBy.Text = "Default";
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(590, 40);
            this.labelSort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(40, 13);
            this.labelSort.TabIndex = 5;
            this.labelSort.Text = "Sort by";
            // 
            // textBoxDetailed
            // 
            this.textBoxDetailed.Location = new System.Drawing.Point(593, 135);
            this.textBoxDetailed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDetailed.Multiline = true;
            this.textBoxDetailed.Name = "textBoxDetailed";
            this.textBoxDetailed.Size = new System.Drawing.Size(281, 290);
            this.textBoxDetailed.TabIndex = 4;
            // 
            // button1
            // 
            this.btnUpdateTicket.Enabled = false;
            this.btnUpdateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTicket.Location = new System.Drawing.Point(593, 71);
            this.btnUpdateTicket.Name = "button1";
            this.btnUpdateTicket.Size = new System.Drawing.Size(136, 59);
            this.btnUpdateTicket.TabIndex = 8;
            this.btnUpdateTicket.Text = "Update Ticket";
            this.btnUpdateTicket.UseVisualStyleBackColor = true;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // btnNewTicket
            // 
            this.btnNewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTicket.Location = new System.Drawing.Point(735, 71);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(139, 59);
            this.btnNewTicket.TabIndex = 7;
            this.btnNewTicket.Text = "Create new Ticket";
            this.btnNewTicket.UseVisualStyleBackColor = true;
            this.btnNewTicket.Click += new System.EventHandler(this.btnNewTicket_Click);
            // 
            // CurrentTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdateTicket);
            this.Controls.Add(this.btnNewTicket);
            this.Controls.Add(this.comboBoxSortBy);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.textBoxDetailed);
            this.Controls.Add(this.listViewTickets);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CurrentTickets";
            this.Size = new System.Drawing.Size(1177, 602);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTickets;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderSubject;
        private System.Windows.Forms.ColumnHeader columnHeaderUser;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderPriority;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.TextBox textBoxDetailed;
        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.Button btnNewTicket;
    }
}
