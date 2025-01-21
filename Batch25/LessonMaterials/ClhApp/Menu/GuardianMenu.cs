using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClhApp.Logic.Interfaces;
using ClhApp.Models;

namespace ClhApp.Menu
{
    public class GuardianMenu
    {
        IBatchLogic batchLogic;
        IStackLogic stackLogic;
        public void GuardianMainMenu()
        {
            Console.WriteLine("1.  Register Student\n2.  View guardians");

            string opt = Console.ReadLine();
            if(opt == "1")
            {
                RegisterStudnetMenu();
                GuardianMainMenu();
            }
        }

        public void RegisterStudnetMenu()
        {
            Console.Write("Email: ");
            string? email = Console.ReadLine();
            Console.Write("Password: ");
            string? password = Console.ReadLine();
            var batches = batchLogic.GetAll();
            
            foreach (Batch batch in batches)
            {
                Console.WriteLine($"  {batch.Id}.   {batch.Name}");
            }
            Console.Write("Select Batch :");
            int batchId = int.Parse(Console.ReadLine());
            Console.Write("First Name: ");
            string? fName = Console.ReadLine();
            Console.Write("Last NAme: ");
            string? lName = Console.ReadLine();
            Console.Write("Address: ");
            string? address = Console.ReadLine();
            Console.Write("Phone Number: ");
            string? phone = Console.ReadLine();
        }
    }
}