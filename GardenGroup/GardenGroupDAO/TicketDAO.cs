using GardenGroupModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GardenGroupDAO
{
    public class TicketDAO : BaseDAO, ITicketDAO
    {
        private string TABLE_NAME = "Incidents";
        public void Create(Ticket newTicket)
        {
            db.InsertDocument<Ticket>(TABLE_NAME, newTicket);
        }

        public void Delete(string id)
        {
            db.DeleteDocument<Ticket>(TABLE_NAME, id);
        }

        public List<Ticket> FindByBranch(string branch)
        {
            var filter = Builders<Ticket>.Filter.Eq("Branch", branch);
            return db.FindByQuery<Ticket>(TABLE_NAME, filter).ToList();
        }

        public Ticket FindById(string id)
        {
            return db.GetDocumentById<Ticket>(TABLE_NAME, id);
        }

        public List<Ticket> FindByType(TypeOfIncident type)
        {
            var filter = Builders<Ticket>.Filter.Eq("Type", type);
            return db.FindByQuery<Ticket>(TABLE_NAME, filter).ToList();
        }

        public List<Ticket> GetAll()
        {
            return db.GetDocuments<Ticket>(TABLE_NAME);
        }

        public void Update(string id, Ticket updatedTicket)
        {
            db.UpdateDocument<Ticket>(id, TABLE_NAME, updatedTicket);
        }

        
        //(DB) - Additional functionality - sorting by priority
        public List<Ticket> GetAllSortedById()
        {
            return db.GetSortedIDDocuments<Ticket>(TABLE_NAME);
        }

        public List<Ticket> GetAllSortedByPriority()
        {
            return db.GetSortedPriorityDocuments<Ticket>(TABLE_NAME);
        }

        public List<Ticket> GetAllSortedByDateReported()
        {
            return db.GetSortedDateReportedDocuments<Ticket>(TABLE_NAME);
        }

        public List<Ticket> GetAllSortedByDeadline()
        {
            return db.GetSortedDeadlineDocuments<Ticket>(TABLE_NAME);
        }

        public List<Ticket> GetAllSortedBySolved()
        {
            return db.GetSortedSolvedDocuments<Ticket>(TABLE_NAME);
        }
    }
}
