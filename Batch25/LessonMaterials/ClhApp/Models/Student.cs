using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClhApp.Models
{
    public class Student
    {
        public int Id{get; set;}
        public int GuardianId{get; set;}
        public int BatchId{get; set;}
        public int StackId{get; set;}
        public string FirstName{get; set;} = default!;
        public string LastName{get; set;} = default!;
        public string AdmissionNumber{get; set;} = default!;
        public string Email{get; set;} = default!;
        public string? Address{get; set;}
        public string Phone{get; set;} = default!;
        public Student(int id, int guardianId,int batchId, int stackId, string firstName, string lastName, string admissionNumber, string email,string address,string phone)
        {
            Id = id;
            GuardianId = guardianId;
            BatchId = batchId;
            StackId = stackId;
            FirstName = firstName;
            LastName = lastName;
            AdmissionNumber = admissionNumber;
            Email = email;
            Address = address;
            Phone = phone;
        }
    }

}