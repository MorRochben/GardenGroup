using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using GardenGroupDAO;

namespace GardenGroupLogic
{
    public class UserService
    {
        UserDAO user_DAO = new UserDAO();

        public List<User> GetAll()
        {
            return user_DAO.GetAll() ;
        }

        public User GetById(string id)
        {
            return user_DAO.FindById(id);
        }
    }
}
