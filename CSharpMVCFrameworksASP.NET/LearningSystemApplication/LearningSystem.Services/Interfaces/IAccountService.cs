using System;

namespace LearningSystem.Services.Interfaces
{
    public interface IAccountService
    {
        void AddStudent(string userId, DateTime birthDate, string name);
    }
}