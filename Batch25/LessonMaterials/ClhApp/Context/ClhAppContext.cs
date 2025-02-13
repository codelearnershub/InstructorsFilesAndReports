using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClhApp.Models;

namespace ClhApp.Context
{
    public class ClhAppContext
    {
        public static List<Batch> Batches = new List<Batch>()
        {
            new Batch(1, "Batch 19", DateTime.Parse("20/08/2023")),
            new Batch(2, "Batch 20", DateTime.Parse("20/01/2024")),
        };
        public static List<Guardian> Guardians = new List<Guardian>();
        public static List<Instructor> Instructors = new List<Instructor>();
        public static List<Stack> Stacks = new List<Stack>()
        {
            new Stack(1,"C#","dotnet"),
            new Stack(2,"python","machine language")
        };
        public static List<Staff> Staffs = new List<Staff>();
        public static List<Student> Students = new List<Student>();
        public static List<User> Users = new List<User>()
        {
            new User(1,"super@yopmail.com","pass","clh_SuperAdmin")
        };
    }
}