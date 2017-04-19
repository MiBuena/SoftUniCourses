using System;
using LearningSystem.Models.EntityModels;
using LearningSystem.Services.Interfaces;

namespace LearningSystem.Services.Services
{
    public class AccountService : Service, IAccountService
    {
        public void AddStudent(string userId, DateTime birthDate, string name)
        {

                Student student = new Student()
                {
                    BirthDate = birthDate,
                    Name = name,
                    UserId = userId
                };

                this.Context.Students.Add(student);


                this.Context.SaveChanges();

        }
    }
}
