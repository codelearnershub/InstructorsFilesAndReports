using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClhApp.Models;

namespace ClhApp.Logic.Interfaces
{
    public interface IBatchLogic
    {
        public void Create(string name, DateTime resumptiondate);
        public Batch Update(int id, DateTime resumptiondate);
        public Batch? Get(int id);
        public List<Batch> GetAll();
        public void Delete(int id);
    }
}