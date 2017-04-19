using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using _01.SimpleMapping.DTOs;

namespace _01.SimpleMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee()
            {
                Address = "Sofia",
                Birthday = new DateTime(2000, 10, 02),
                FirstName = "Peter",
                Salary = 2000M
            };


            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDTO>();

            });

            //EmployeeDTO mapped = (EmployeeDTO) Mapper.Map(firstEmployee, firstEmployee.GetType(), typeof(EmployeeDTO));
            var mapped = Mapper.Map<Employee, EmployeeDTO>(firstEmployee);

            Console.WriteLine($"{mapped.FirstName} {mapped.LastName} {mapped.Salary}");
        }
    }
}
