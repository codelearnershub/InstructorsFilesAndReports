using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClhApp.Logic.Interfaces
{
    public interface IInstructorLogic
    {
        public void Create(int staffId,int stackId);
        public void Delete(int id);

    }
}