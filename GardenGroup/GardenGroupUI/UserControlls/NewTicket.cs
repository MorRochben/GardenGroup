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
    public partial class NewTicket : UserControl
    {
        CurrentTickets mainForm;

        public NewTicket(CurrentTickets mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            cmbIncicentType.DataSource = Enum.GetValues(typeof(TypeOfIncident));
            cmbPriority.DataSource = Enum.GetValues(typeof(Priority));
            numReportHour.Value = dateReported.Value.Hour;
            numReportMinute.Value = dateReported.Value.Minute;
            dateDeadline.Value = DateTime.Now;
            lblDeadLineError.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            txtDescription.Text.Replace("\n", "\r\n");
            DateTime reportedDateTime = dateReported.Value.Date + new TimeSpan((int)numReportHour.Value, (int)numReportMinute.Value, 0);
            Ticket ticket = new Ticket(
                txtSubject.Text,
                txtDescription.Text,
                "5f80617420cbf591a8169575", // needs to be changed to the ID of the logged in user
                reportedDateTime,
                dateDeadline.Value.Date,
                (TypeOfIncident)cmbIncicentType.SelectedIndex,
                (Priority)cmbPriority.SelectedIndex
            );
            TicketService ticketService = new TicketService();
            ticketService.CreateTicket(ticket);
            mainForm.changedListSort();
            Close();
        }

        private void Close()
        {
            mainForm.displayAllTickets();
            mainForm.Show();
            mainForm.UCNewIncident.Dispose();
            mainForm.UCNewIncident = null;
        }

        private void numReportHour_ValueChanged(object sender, EventArgs e)
        {
            if (numReportHour.Value == 24)
            {
                numReportHour.Value = 0;
            }
            if (numReportHour.Value == -1)
            {
                numReportHour.Value = 23;
            }
        }

        private void numReportMinute_ValueChanged(object sender, EventArgs e)
        {
            if (numReportMinute.Value == 60)
            {
                numReportMinute.Value = 0;
            }
            if (numReportMinute.Value == -1)
            {
                numReportMinute.Value = 59;
            }
        }

        private void dateDeadline_ValueChanged(object sender, EventArgs e)
        {
            if(dateDeadline.Value.Date < dateReported.Value.Date)
                lblDeadLineError.Show();
            else
                lblDeadLineError.Hide();
        }

    }
}
