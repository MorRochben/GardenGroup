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
using GardenGroupUI.UserControlls;

namespace GardenGroupUI
{
    public partial class CurrentTickets : UserControl
    {
        public NewTicket UCNewIncident;
        public UpdateTicket UCUpdateTicket;

        private List<Ticket> tickets;
        private TicketService ticketService;
        private UserService userService;

        private User loggedInUser;

        private List<User> users;

        public CurrentTickets()
        {
            InitializeComponent();
            this.Size = ClientSize;
            ticketService = new TicketService();
            userService = new UserService();
            Start();
        }

        private void Start()
        {
            loggedInUser = Session.Instance.LoggedInUser;
            users = userService.GetAll();

            lbl_Welcome.Text = "Welcome " + loggedInUser.FirstName + " " + loggedInUser.LastName;
            lbl_typeUser.Text = "Type: " + loggedInUser.TypeOfUser;

            if(loggedInUser.TypeOfUser.Equals(TypeOfUser.EndUser))
            {
                btnUpdateTicket.Enabled = false;
                btnUpdateTicket.Visible = false;

                btnDeleteTicket.Enabled = false;
                btnDeleteTicket.Visible = false;

                archive.Enabled = false;
                archive.Visible = false;
            }

            displayAllTickets();
        }

        public void displayAllTickets()
        {
            listViewTickets.Items.Clear();

            if(tickets == null)
            {
                if (loggedInUser.TypeOfUser.Equals(TypeOfUser.EndUser))
                    tickets = ticketService.GetFromUserSortedById(loggedInUser);
                else
                    tickets = ticketService.GetAllSortedById();
            }

            foreach (Ticket item in tickets)
            {

                string[] row = { item.Id, item.Subject, getReportedBy(item.ReportedBy), item.ReportedDate.ToString("dd-MM-yyyy"), item.Priority.ToString() };
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

            //alligning the text
            string description = selectedTicket.Description.Replace("\n", "\n\t\t");

            textBoxDetailed.Lines = new string[]
            {
                String.Format("ID: \t\t{0}", selectedTicket.Id),
                String.Format("Subject: \t\t{0}", selectedTicket.Subject),
                String.Format("Description: \t{0, -25}", description),
                String.Format("Reported by: \t{0, -25}", getReportedBy(selectedTicket.ReportedBy)),
                String.Format("Reported date: \t{0, -25}", selectedTicket.ReportedDate),
                String.Format("Deadline: \t\t{0, -25}", selectedTicket.Deadline),
                String.Format("Incident type: \t{0, -25}", selectedTicket.Type),
                String.Format("Priority: \t\t{0, -25}", selectedTicket.Priority),
                String.Format("Solved incident? \t{0, -25}", selectedTicket.IsSolved),
            };

        }

        private string getReportedBy(string id)
        {
            string reportedByFullName = "";

            foreach (User user in users)
            {
                if (id.Equals(user.Id))
                {
                    reportedByFullName = user.FirstName + " " + user.LastName;
                    break;
                }
            }

            return reportedByFullName;
        }

        private Ticket GetSelectedTicket()
        {
            Ticket selectedTicket = null;
            foreach (Ticket ticket in tickets)
            {
                if (listViewTickets.SelectedItems.Count > 0)
                    if (listViewTickets.SelectedItems[0].Text.Equals(ticket.Id))
                        selectedTicket = ticket;

            }
            return selectedTicket;
        }

        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedListSort();
        }

        public void changedListSort()
        {
            string selectedOption = comboBoxSortBy.Text;

            List<Ticket> sortedList = tickets;

            if (loggedInUser.TypeOfUser.Equals(TypeOfUser.EndUser))
            {
                switch (selectedOption)
                {
                    case "Default":
                        sortedList = ticketService.GetFromUserSortedById(loggedInUser);
                        break;
                    case "Priority":
                        sortedList = ticketService.GetFromUserSortedByPriority(loggedInUser);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (selectedOption)
                {
                    case "Default":
                        sortedList = ticketService.GetAllSortedById();
                        break;
                    case "Priority":
                        sortedList = ticketService.GetAllSortedByPriority();
                        break;
                    case "Date reported":
                        sortedList = ticketService.GetAllSortedByDateReported();
                        break;
                    case "Deadline":
                        sortedList = ticketService.GetAllSortedByDeadline();
                        break;
                    case "Solved":
                        sortedList = ticketService.GetAllSortedBySolved();
                        break;
                    default:
                        break;
                }
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
            UCNewIncident.BringToFront();
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            if (UCNewIncident != null || UCUpdateTicket != null )
                return;

            this.Hide();
            Ticket ticket = GetSelectedTicket();
            UCUpdateTicket = new UpdateTicket(this, ticket);
            Parent.Controls.Add(UCUpdateTicket);
            UCNewIncident.BringToFront();
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = GetSelectedTicket();

            if (ticket == null)
                return;

            ticketService.DeleteTicket(ticket.Id);
            tickets = null;
            displayAllTickets();
        }

        // (MVL)
        private void archive_Click(object sender, EventArgs e)
        {
            ticketService.ArchiveTickets();
            listViewTickets.Items.Clear();

            if (loggedInUser.TypeOfUser.Equals(TypeOfUser.EndUser))
            {
                tickets = ticketService.GetFromUserSortedById(loggedInUser);
            } else
            {
                tickets = ticketService.GetAllSortedById();
            }

            foreach (Ticket item in tickets)
            {

                string[] row = { item.Id, item.Subject, getReportedBy(item.ReportedBy), item.ReportedDate.ToString("dd-MM-yyyy"), item.Priority.ToString() };
                listViewTickets.Items.Add(new ListViewItem(row));
            }
        }
    }
}