using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClhApp.Models
{
    public class Batch
    {
        public int Id{get; set;}
        public string Name{get; set;} = default!;
        public DateTime ResumptionDate{get; set;}

        public Batch(int id, string name, DateTime resumptiondate)
        {
            Id = id;
            Name = name;
            ResumptionDate = resumptiondate;
        }
    }
}