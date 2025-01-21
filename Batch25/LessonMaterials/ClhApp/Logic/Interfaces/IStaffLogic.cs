using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClhApp.Models;

namespace ClhApp.Logic.Interfaces
{
    public interface IStaffLogic
    {
        public void Create(string fn, string ln, string email, string staffNumber, string address, string phone);
        public Staff Get(int id);
        public List<Staff> GetAll();
        public Staff Update(string fn, string ln, string staffNumber, string address, string phone);
        public void Delete(int id);
    }
}