using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClhApp.Models;

namespace ClhApp.Logic.Interfaces
{
    public interface IStudentLogic
    {
        public bool Create(string email, string password, int batchId, int stackId, string firstName, string lastName, string address,string phone);
        public Student Get(int id);
        public List<Student> GetAll();
        public Student Update(int batchId, int stackId, string firstName, string lastName,string address,string phone);
        public void Delete(int id);
    }
}