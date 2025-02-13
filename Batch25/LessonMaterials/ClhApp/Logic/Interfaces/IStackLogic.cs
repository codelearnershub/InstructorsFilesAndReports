using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClhApp.Models;
using Microsoft.VisualBasic.FileIO;

namespace ClhApp.Logic.Interfaces
{
    public interface IStackLogic
    {
        public void Create(string name, string description);
        public Stack Update(int id,string name, string description);
        public Stack Get(int id);
        public List<Stack> GetAll();
        public void Delete(int id);
    }
}