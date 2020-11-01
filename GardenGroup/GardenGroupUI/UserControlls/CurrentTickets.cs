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
using GardenGroupDAO;
using GardenGroupUI.UserControlls;

namespace GardenGroupUI
{
    public partial class CurrentTickets : UserControl
    {
        public NewTicket UCNewIncident;
        public UpdateTicket UCUpdateTicket;

        private List<Ticket> tickets;
        public CurrentTickets()
        {
            InitializeComponent();
            this.Size = ClientSize;
            Start();
        }

        private void Start()
        {
            UserDAO userDAO = new UserDAO();
            List<User> users = userDAO.GetAll();


            displayAllTickets();
        }

        public void displayAllTickets()
        {
            listViewTickets.Items.Clear();
            TicketDAO ticketDAO = new TicketDAO();

            //tickets = ticketDAO.GetAll().OrderByDescending(o => o.Id).ToList();
            if(tickets == null)
            {
                tickets = ticketDAO.GetAllSortedById();
            }

            foreach (Ticket item in tickets)
            {
                string[] row = { item.Id, item.Subject, item.ReportedBy, item.ReportedDate.ToString("dd-MM-yyyy"), item.Priority.ToString() };
                listViewTickets.Items.Add(new ListViewItem(row));
            }
        }


        private void listViewTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdateTicket.Enabled = listViewTickets.SelectedItems.Count > 0;

            Ticket selectedTicket = GetSelectedTicket();

            if (selectedTicket == null)
            {
                textBoxDetailed.Text = "";
                return;
            }

            string ticketString = String.Format(
                "Subject: {0} " + Environment.NewLine +
                "Description: {1} " + Environment.NewLine +
                "Reported by: {2} " + Environment.NewLine +
                "Reported date: {3} " + Environment.NewLine +
                "Deadline: {4} " + Environment.NewLine +
                "Type of incident: {5} " + Environment.NewLine +
                "Priority level: {6} " + Environment.NewLine +
                "Is the incident solved? {7}",
                selectedTicket.Subject, selectedTicket.Description, selectedTicket.ReportedBy, selectedTicket.ReportedDate, selectedTicket.Deadline,
                selectedTicket.Type, selectedTicket.Priority, selectedTicket.IsSolved);

            textBoxDetailed.Text = ticketString;
        }

        private Ticket GetSelectedTicket()
        {
            Ticket selectedTicket = null;
            foreach (Ticket ticket in tickets)
            {
                //Console.WriteLine(listViewTickets.SelectedItems);

                if (listViewTickets.SelectedItems.Count > 0)
                    if (listViewTickets.SelectedItems[0].Text.Equals(ticket.Id))
                        selectedTicket = ticket;

            }
            return selectedTicket;
        }


        // individually queries are better
        // change it up so that its own sorting queries
        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedListSort();
        }

        public void changedListSort()
        {
            string selectedOption = comboBoxSortBy.Text;

            List<Ticket> sortedList = tickets;

            TicketDAO ticketDAO = new TicketDAO();

            switch (selectedOption)
            {
                case "Default":
                    sortedList = ticketDAO.GetAllSortedById();
                    break;
                case "Priority":
                    sortedList = ticketDAO.GetAllSortedByPriority();
                    break;
                case "Date reported":
                    sortedList = tickets.OrderByDescending(o => o.ReportedBy).ToList();
                    break;
                case "Deadline":
                    sortedList = tickets.OrderByDescending(o => o.Deadline).ToList();
                    break;
                case "Solved":
                    sortedList = tickets.OrderByDescending(o => o.IsSolved).ToList();
                    break;
                default:
                    break;
            }

            listViewTickets.Items.Clear();

            tickets = sortedList;
            displayAllTickets();
        }

        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            if (UCNewIncident != null || UCUpdateTicket != null)
                return;

            this.Hide();
            UCNewIncident = new NewTicket(this);
            Parent.Controls.Add(UCNewIncident);
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            if (UCNewIncident != null || UCUpdateTicket != null )
                return;

            this.Hide();
            Ticket ticket = GetSelectedTicket();
            UCUpdateTicket = new UpdateTicket(this, ticket);
            Parent.Controls.Add(UCUpdateTicket);
        }
    }
}