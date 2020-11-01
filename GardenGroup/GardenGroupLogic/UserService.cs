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

        public void SendEmail(string email)
        {
            string pass = getNewPassword();
            user_DAO.sendEmail(email, pass);
            user_DAO.resetPass(email, pass);        
        }

        public string getNewPassword()
        {
            var validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = validChars[random.Next(validChars.Length)];
            }

            var finalString = new string(stringChars);
            return finalString;
        }
    }
}
