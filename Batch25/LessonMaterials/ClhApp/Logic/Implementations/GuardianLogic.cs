using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClhApp.Context;
using ClhApp.Logic.Interfaces;
using ClhApp.Models;

namespace ClhApp.Logic.Implementations
{
    public class GuardianLogic : IGuardianLogic
    {
        IUserLogic userLogic = new UserLogic();
        public bool Create(string email, string password, string firstName, string lastName, string address, string phone)
        {
            var userExist = userLogic.UserExist(email);
            if(userExist)
            {
                return false;
            }

            var user = new User(ClhAppContext.Users.Count + 1,email,password,"clh_guardian");
            ClhAppContext.Users.Add(user);

            var guardian = new Guardian(ClhAppContext.Guardians.Count+1,firstName,lastName,email,address,phone);
            ClhAppContext.Guardians.Add(guardian);

            return true;
        }

        public List<Guardian> GetAll()
        {
            return ClhAppContext.Guardians;
        }

        public Guardian? GetGuardianByEmail(string email)
        {
            foreach (Guardian guardian in ClhAppContext.Guardians)
            {
                if(guardian.Email == email)
                {
                    return guardian;
                }
            }
            return null;
        }
    }
}