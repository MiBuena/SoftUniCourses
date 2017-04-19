using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstStudentSystem.Data;
using CodeFirstStudentSystem.Models;

namespace CodeFirstStudentSystem.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentSystemContext context = new StudentSystemContext();

            context.Resources.FirstOrDefault();

            //Task 1
            //Lists all students and their homework submissions.
            //Print only their names and for each homework -content and content - type.

            //List <Student> students = context.Students.ToList();

            // foreach (var student in students)
            // {
            //     Console.WriteLine(student.Name);

            //     foreach (var homework in student.Homeworks)
            //     {
            //         Console.WriteLine(homework.Content);
            //         Console.WriteLine(homework.ContentType);
            //     }

            //     Console.WriteLine();
            // }

            //Task 2 List all courses with their corresponding resources.
            //var courses = context.Courses.OrderBy(x => x.StartDate).ThenByDescending(y => y.EndDate);

            //foreach (var course in courses)
            //{
            //    Console.WriteLine(course.Name);
            //    Console.WriteLine(course.Description);

            //    foreach (var resource in course.Resources)
            //    {
            //        Console.WriteLine(resource);
            //    }

            //    Console.WriteLine();
            //}

            //Task 3 List all courses with more than 5 resources. 

            //List<Course> courses =
            //    context.Courses.Where(x => x.Resources.Count > 5)
            //        .OrderByDescending(y => y.Resources.Count)
            //        .ThenByDescending(y => y.StartDate)
            //        .ToList();

            //foreach (var course in courses)
            //{
            //    Console.WriteLine(course.Name);
            //    Console.WriteLine(course.Resources.Count);

            //    Console.WriteLine();
            //}

            //Task 4 List all courses which were active on a given date

            //DateTime date = new DateTime(2016, 11, 19);

            //List<Course> courses = context.Courses.Where(x => x.EndDate > date).OrderByDescending(x=>x.Students.Count).ToList();

            //foreach (var element in courses)
            //{
            //    Console.WriteLine(element.Name);
            //    Console.WriteLine(element.StartDate);
            //    Console.WriteLine(element.EndDate);
            //    Console.WriteLine((element.EndDate - element.StartDate).TotalDays);
            //    Console.WriteLine(element.Students.Count);
            //}

            //Task 5 For each student, calculate the number of courses he/she has enrolled in

            //var students =
            //    context.Students.OrderByDescending(x => x.Courses.Sum(y => y.Price))
            //        .ThenByDescending(x => x.Courses.Count)
            //        .ThenBy(z => z.Name)
            //        .ToList();


            //foreach (var element in students)
            //{
            //    Console.WriteLine(element.Name);
            //    Console.WriteLine(element.Courses.Count);
            //    if(element.Courses.Any())
            //    {
            //        Console.WriteLine(element.Courses.Sum(x => x.Price));
            //        Console.WriteLine(element.Courses.Average(x => x.Price));
            //    }

            //    Console.WriteLine();
            //}



        }
    }
}
