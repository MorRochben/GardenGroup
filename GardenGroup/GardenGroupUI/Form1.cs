using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GardenGroupDAO;
using GardenGroupModel;

namespace GardenGroupUI
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            GardenGroupDAO.MongoDB db = GardenGroupDAO.MongoDB.Instance;
            TicketDAO ticketDAO = new TicketDAO();
            UserDAO userDAO = new UserDAO();

            List<Ticket> tickets = ticketDAO.GetAll();
            List<User> users = userDAO.GetAll();

            displayAllTickets();
        }

        private void displayAllTickets()
        {
            TicketDAO ticketDAO = new TicketDAO();
            List<Ticket> tickets = ticketDAO.GetAll();

            foreach (Ticket item in tickets)
            {
                string[] row = { "*ID", item.Subject, "*User", item.ReportedDate.ToString("dd-MM-yyyy"), "*Priority" };
                listViewTickets.Items.Add(new ListViewItem(row));
            }
        }

        private void lv_tickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string index = lv_tickets.SelectedItems[0].Text;
        }
    }
}
