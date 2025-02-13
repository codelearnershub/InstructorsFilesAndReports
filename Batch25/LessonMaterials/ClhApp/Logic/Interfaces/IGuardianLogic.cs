using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClhApp.Models;

namespace ClhApp.Logic.Interfaces
{
    public interface IGuardianLogic
    {
        public bool Create(string email, string password, string firstName, string lastName, string address, string phone);
        public Guardian? GetGuardianByEmail(string email);
        public List<Guardian> GetAll();
    }
}