using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClhApp.Models
{
    public class User
    {
        public int Id{get; set;}
        public string Email{get; set;} = default!;
        public string Password{get; set;} = default!;
        public string Role{get; set;} = default!;

        public User(int id, string email, string password, string role)
        {
            Id = id;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}