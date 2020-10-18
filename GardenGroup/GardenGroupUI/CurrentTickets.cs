﻿using System;
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
            TicketDAO ticketDAO = new TicketDAO();
            UserDAO userDAO = new UserDAO();

            tickets = ticketDAO.GetAll().OrderByDescending(o => o.Id).ToList();
            List<User> users = userDAO.GetAll();


            displayAllTickets();
        }

        private void displayAllTickets()
        {
            foreach (Ticket item in tickets)
            {
                string[] row = { item.Id, item.Subject, item.ReportedBy, item.ReportedDate.ToString("dd-MM-yyyy"), item.Priority.ToString() };
                listViewTickets.Items.Add(new ListViewItem(row));
            }
        }


        private void listViewTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ticket selectedTicket = new Ticket();
            foreach (Ticket ticket in tickets)
            {
                Console.WriteLine(listViewTickets.SelectedItems);

                if (listViewTickets.SelectedItems.Count > 0)
                    if (listViewTickets.SelectedItems[0].Text.Equals(ticket.Id))
                        selectedTicket = ticket;

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


        // individually queries are better
        // change it up so that its own sorting queries
        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (UCNewIncident != null || UCUpdateTicket != null)
                return;

            //FOR TESTING ONLY
            GardenGroupLogic.TicketService ts = new GardenGroupLogic.TicketService();
            GardenGroupModel.Ticket ticket = ts.FindById("5f75feadf05676980529f18c");

            this.Hide();
            UCUpdateTicket = new UpdateTicket(this, ticket);
            Parent.Controls.Add(UCUpdateTicket);
        }
    }
}
