using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GardenGroupModel;
using GardenGroupLogic;

namespace GardenGroupUI.UserControlls
{
    public partial class UpdateTicket : UserControl
    {
        private Ticket ticket;
        private CurrentTickets mainForm;

        public UpdateTicket(CurrentTickets mainForm, Ticket ticket)
        {
            InitializeComponent();
            this.ticket = ticket;
            this.mainForm = mainForm;
            cmbIncicentType.DataSource = Enum.GetValues(typeof(TypeOfIncident));
            cmbPriority.DataSource = Enum.GetValues(typeof(Priority));
            lblDeadLineError.Hide();

            txtSubject.Text = ticket.Subject;
            txtDescription.Text = ticket.Description;
            lblUsername.Text = ticket.ReportedBy;
            lblReportDate.Text = ticket.ReportedDate.ToString("dd/MM/yyyy H:mm");
            cmbIncicentType.SelectedItem = ticket.Type;
            cmbPriority.SelectedItem = ticket.Priority;
            cheSolved.Checked = ticket.IsSolved;
            dateDeadline.Value = ticket.Deadline;
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            TicketService ticketService = new TicketService();

            ticketService.UpdateTicket(ticket);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Close()
        {
            mainForm.Controls.Remove(mainForm.UCUpdateTicket);
            mainForm.UCUpdateTicket.Dispose();
            mainForm.UCUpdateTicket = null;
        }

        private void dateDeadline_ValueChanged(object sender, EventArgs e)
        {
            if (dateDeadline.Value.Date < ticket.ReportedDate)
                lblDeadLineError.Show();
            else
            {
                lblDeadLineError.Hide();
                ticket.Deadline = dateDeadline.Value.Date;
            }
        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {
            ticket.Subject = txtSubject.Text;
        }

        private void cmbIncicentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ticket.Type = (TypeOfIncident)cmbIncicentType.SelectedIndex;
        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            ticket.Priority = (Priority)cmbPriority.SelectedIndex;
        }

        private void cheSolved_CheckedChanged(object sender, EventArgs e)
        {
            ticket.IsSolved = cheSolved.Checked;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            ticket.Description = txtDescription.Text;
        }
    }
}
