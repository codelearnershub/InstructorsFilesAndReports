using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClhApp.Models
{
    public class Stack
    {
        public int Id{get; set;}
        public string Name{get; set;} = default!;
        public string? Description{get; set;}

        public Stack(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}