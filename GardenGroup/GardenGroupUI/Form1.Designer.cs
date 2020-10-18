namespace GardenGroupUI
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabIncidentManagement = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewIncident = new System.Windows.Forms.Button();
            this.tabUserManagement = new System.Windows.Forms.TabPage();
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabIncidentManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabIncidentManagement);
            this.tabControl1.Controls.Add(this.tabUserManagement);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.Transparent;
            this.tabHome.Location = new System.Drawing.Point(4, 25);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(776, 533);
            this.tabHome.TabIndex = 2;
            this.tabHome.Text = "Home";
            // 
            // tabIncidentManagement
            // 
            this.tabIncidentManagement.BackColor = System.Drawing.Color.Transparent;
            this.tabIncidentManagement.Controls.Add(this.btnUpdateTicket);
            this.tabIncidentManagement.Controls.Add(this.label1);
            this.tabIncidentManagement.Controls.Add(this.btnNewIncident);
            this.tabIncidentManagement.Location = new System.Drawing.Point(4, 25);
            this.tabIncidentManagement.Name = "tabIncidentManagement";
            this.tabIncidentManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabIncidentManagement.Size = new System.Drawing.Size(776, 533);
            this.tabIncidentManagement.TabIndex = 0;
            this.tabIncidentManagement.Text = "Incident Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnNewIncident
            // 
            this.btnNewIncident.Location = new System.Drawing.Point(596, 20);
            this.btnNewIncident.Name = "btnNewIncident";
            this.btnNewIncident.Size = new System.Drawing.Size(150, 34);
            this.btnNewIncident.TabIndex = 0;
            this.btnNewIncident.Text = "New Incident ";
            this.btnNewIncident.UseVisualStyleBackColor = true;
            this.btnNewIncident.Click += new System.EventHandler(this.btnNewIncident_Click);
            // 
            // tabUserManagement
            // 
            this.tabUserManagement.BackColor = System.Drawing.Color.Transparent;
            this.tabUserManagement.Location = new System.Drawing.Point(4, 25);
            this.tabUserManagement.Name = "tabUserManagement";
            this.tabUserManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserManagement.Size = new System.Drawing.Size(776, 533);
            this.tabUserManagement.TabIndex = 1;
            this.tabUserManagement.Text = "User Management";
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.Location = new System.Drawing.Point(596, 96);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(150, 34);
            this.btnUpdateTicket.TabIndex = 2;
            this.btnUpdateTicket.Text = "Update Ticket";
            this.btnUpdateTicket.UseVisualStyleBackColor = true;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabIncidentManagement.ResumeLayout(false);
            this.tabIncidentManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabIncidentManagement;
        private System.Windows.Forms.TabPage tabUserManagement;
        private System.Windows.Forms.Button btnNewIncident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateTicket;
    }
}

