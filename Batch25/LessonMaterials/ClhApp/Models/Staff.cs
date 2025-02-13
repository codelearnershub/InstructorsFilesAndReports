using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClhApp.Models
{
    public class Staff
    {
        public int Id{get; set;}
        public string FirstName{get; set;} = default!;
        public string LastName{get; set;} = default!;
        public string Email{get; set;} = default!;
        public string StaffNumber{get; set;} = default!;
        public string? Address{get; set;}
        public string Phone{get; set;} = default!;

        public Staff(int id, string fn, string ln, string email, string staffNumber, string address, string phone)
        {
            Id = id;
            FirstName = fn;
            LastName = ln;
            Email =email;
            StaffNumber = staffNumber;
            Address = address;
            Phone = phone;
        }
    }
}