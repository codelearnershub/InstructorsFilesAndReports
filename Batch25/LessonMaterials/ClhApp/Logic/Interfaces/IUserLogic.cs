using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClhApp.Models;

namespace ClhApp.Logic.Interfaces
{
    public interface IUserLogic
    {
        public User? Login(string email, string password);
        public User? GetCurrentLogginUser();
        public bool UserExist(string email);
    }
}