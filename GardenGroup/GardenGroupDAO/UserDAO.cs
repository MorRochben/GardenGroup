using GardenGroupModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace GardenGroupDAO
{
    public class UserDAO : BaseDAO, IUserDAO
    {
        private const string TABLE_NAME = "Users";
        public void Create(User newUser)
        {
            User user = FindOneByEmail(newUser.Email);

            if (user != null)
            {
                throw new Exception("Email already in use!");
            }

            db.InsertDocument<User>(TABLE_NAME, newUser);
        }

        public void Delete(string id)
        {
            db.DeleteDocument<User>(TABLE_NAME, id);
        }

        public User FindOneByEmail(string email)
        {
            var filter = Builders<User>.Filter.Eq("Email", email);
            List<User> users = db.FindByQuery<User>(TABLE_NAME, filter);

            return users.Count > 0 ? users[0] : null;
        }

        public User FindById(string id)
        {
            return db.GetDocumentById<User>(TABLE_NAME, id);
        }

        public List<User> GetAll()
        {
            return db.GetDocuments<User>(TABLE_NAME);
        }

        public void Update(string id, User user)
        {
            db.UpdateDocument<User>(id, TABLE_NAME, user);
        }
    }
}
