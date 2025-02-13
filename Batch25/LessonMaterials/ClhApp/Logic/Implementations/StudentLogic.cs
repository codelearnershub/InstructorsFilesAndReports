using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClhApp.Context;
using ClhApp.Logic.Interfaces;
using ClhApp.Models;

namespace ClhApp.Logic.Implementations
{
    public class StudentLogic : IStudentLogic
    {
        IUserLogic userLogic = new UserLogic();
        IGuardianLogic guardianLogic = new GuardianLogic();
        public bool Create(string email, string password, int batchId, int stackId, string firstName, string lastName, string address, string phone)
        {
            var exists = userLogic.UserExist(email);
            if(exists)
            {
                return false;
            }
            var user = new User(ClhAppContext.Users.Count+1,email,password,"clh_student");
            

            var loginUser = userLogic.GetCurrentLogginUser();
            if(loginUser == null)
            {
                return false;
            }
            var guardian = guardianLogic.GetGuardianByEmail(loginUser.Email);
            if(guardian == null)
            {
                return false;
            }
            var student = new Student(ClhAppContext.Students.Count+1,guardian.Id,batchId,stackId,firstName,lastName,GenAdminNum(),email,address,phone);

            ClhAppContext.Users.Add(user);
            ClhAppContext.Students.Add(student);
            return true;
        }

        private string GenAdminNum()
        {
            return $"CLHH/{DateTime.Now.Year}/{new Random().Next(1000,9999)}";
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student Update(int batchId, int stackId, string firstName, string lastName, string address, string phone)
        {
            throw new NotImplementedException();
        }
    }
}