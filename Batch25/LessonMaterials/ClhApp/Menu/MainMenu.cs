using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClhApp.Logic.Implementations;
using ClhApp.Logic.Interfaces;
using ClhApp.Models;

namespace ClhApp.Menu
{
    public class MainMenu
    {
        IGuardianLogic guardianLogic = new GuardianLogic();
        IUserLogic userLogic = new UserLogic();
        public void Start()
        {
            Console.WriteLine("==> Welcome to CLH portal <==");
            Console.WriteLine("1.  Register\n2.  Login\n3.  View guardians");

            string? opt = Console.ReadLine();

            if(opt == "1")
            {
                RegisterMenu();
                Start();
            }
            else if(opt == "2")
            {
                LoginMenu();
            }
            else if(opt == "3")
            {
                Guardians();
            }
            else
            {
                Console.WriteLine("invalid option");
                Start();
            }
        }

        public void RegisterMenu()
        {
            Console.Write("Email: ");
            string? email = Console.ReadLine();
            Console.Write("Password: ");
            string? password = Console.ReadLine();
            Console.Write("First Name: ");
            string? fName = Console.ReadLine();
            Console.Write("Last NAme: ");
            string? lName = Console.ReadLine();
            Console.Write("Address: ");
            string? address = Console.ReadLine();
            Console.Write("Phone Number: ");
            string? phone = Console.ReadLine();

            var response = guardianLogic.Create(email,password,fName,lName,address,phone);
            if(!response)
            {
                Console.WriteLine($"{email} already exist");
            }
            else
            {
                Console.WriteLine("registration succesful");
            }

        }

        public void LoginMenu()
        {
            Console.Write("Email: ");
            string? email = Console.ReadLine();
            Console.Write("Password: ");
            string? password = Console.ReadLine();

            var response = userLogic.Login(email,password);
            if(response == null)
            {
                Console.WriteLine("invalid cridentials");
                LoginMenu();
            }
            else
            {
                if(response.Role == "clh_SuperAdmin")
                {
                    SuperMenu superMenu = new SuperMenu();
                    superMenu.SuperManinMenu();
                }
                else if(response.Role == "clh_guardian")
                {
                    GuardianMenu guardianMenu = new GuardianMenu();
                    guardianMenu.GuardianMainMenu();
                }
            }
        }
        public void Guardians()
        {
            var guardians = guardianLogic.GetAll();
            foreach(Guardian guardian in guardians)
            {
                Console.WriteLine($"{guardian.Id}\t{guardian.FirstName} {guardian.LastName}\t{guardian.Phone}");
            }
        }
    }
}