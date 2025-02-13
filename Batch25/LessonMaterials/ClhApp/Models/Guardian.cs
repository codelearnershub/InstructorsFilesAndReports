using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClhApp.Models
{
    public class Guardian
    {
        public int Id{get; set;}
        public string FirstName{get; set;} = default!;
        public string LastName{get; set;} = default!;
        public string Email{get; set;} = default!;
        public string? Address{get; set;}
        public string Phone{get; set;} = default!;
        public Guardian(int id, string firstName, string lastName, string email, string address, string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            Phone = phone;
        }
    }
}