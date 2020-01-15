using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserLogin.LoginService.Database
{
    public class LoginDatabase
    {
        public static Dictionary<Guid, DateTime> ConnectedUsers = new Dictionary<Guid, DateTime>();
        public static List<UserLogin> UserDatabase = new List<UserLogin>();

        public LoginDatabase()
        {
            UserLogin userLogin = new UserLogin()
            {
                Email = "Dupond.martine@ynovcorp.com",
                Password = "test1"
            };
            UserDatabase.Add(userLogin);
            userLogin = new UserLogin()
            {
                Email = "Kent.clark@ynovcorp.com",
                Password = "test2"
            };
            UserDatabase.Add(userLogin);
            userLogin = new UserLogin()
            {
                Email = "Cooper.sheldon@ynovcorp.com",
                Password = "test3"
            };
            UserDatabase.Add(userLogin);
        }
    }

}
