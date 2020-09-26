using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupDAO;
using GardenGroupModel;

namespace GardenGroupLogic
{
    public class TicketService
    {
        TicketDAO ticketDAO;

        public TicketService()
        {
            ticketDAO = new TicketDAO();
        }

        public void CreateTicket(Ticket ticket)
        {
            ticketDAO.Create(ticket);
        }

        public void DeleteTicket(string id)
        {
            ticketDAO.Delete(id);
        }

        public void UpdateTicket(Ticket ticket)
        {
            if (ticket.Id == null)
                return;
            ticketDAO.Update(ticket.Id, ticket);
        }

        public void UpdateTicket(string id, Ticket ticket)
        {
            ticket.Id = id;
            UpdateTicket(ticket);
        }
    }
}
