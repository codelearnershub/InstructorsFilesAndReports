using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClhApp.Context;
using ClhApp.Logic.Interfaces;
using ClhApp.Models;

namespace ClhApp.Logic.Implementations
{
    public class UserLogic : IUserLogic
    {
        public static User? CurrentUser = null;

        public User? GetCurrentLogginUser()
        {
            return CurrentUser;
        }

        public User? Login(string email, string password)
        {
            foreach(User user in ClhAppContext.Users)
            {
                if(user.Email == email && user.Password == password)
                {
                    CurrentUser = user;
                    return user;
                }
            }
            return null;
        }

        public bool UserExist(string email)
        {
            foreach (var user in ClhAppContext.Users)
            {
                if(user.Email == email)
                {
                    return true;
                }
            }
            return false;
        }
    }
}