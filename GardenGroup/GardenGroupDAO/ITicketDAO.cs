using GardenGroupModel;
using System.Collections.Generic;

namespace GardenGroupDAO
{
    interface ITicketDAO
    {
        void Create(Ticket newTicket);
        void Update(string id, Ticket updatedTicket);
        void Delete(string id);
        List<Ticket> FindByType(TypeOfIncident type);
        List<Ticket> FindByBranch(string branch);
        List<Ticket> GetAll();
        Ticket FindById(string id);
    }
}
