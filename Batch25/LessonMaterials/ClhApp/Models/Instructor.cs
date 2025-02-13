using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClhApp.Models
{
    public class Instructor
    {
        public int Id{get; set;}
        public int StaffId{get; set;}
        public int StackId{get; set;}
        
        public Instructor(int id, int staffId,int stackId)
        {
            Id = id;
            StaffId = staffId;
            StackId = stackId;
        }
    }

}