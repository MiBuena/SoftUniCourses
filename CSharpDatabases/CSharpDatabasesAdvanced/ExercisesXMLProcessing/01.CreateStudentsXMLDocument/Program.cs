using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _01.CreateStudentsXMLDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam firstExam = new Exam()
            {
                DateTaken = new DateTime(2016, 01, 01),
                Grade = 5.5M,
                Name = "OOP"
            };

            Exam secondExam = new Exam()
            {
                DateTaken = new DateTime(2016, 05, 01),
                Grade = 10M,
                Name = "C#"
            };

            Student student = new Student()
            {
                BirthDate = new DateTime(1988, 10, 01),
                Email = "sdfds@abv.bg",
                FacultyNumber = "1249",
                Gender = "f",
                Name = "Pesho",
                PhoneNumber = "0878283949",
                Specialty = "Programming",
                University = "University"
            };

            student.Exams.Add(firstExam);
            student.Exams.Add(secondExam);


            
            var xmlDocument = new XElement("students");

            var studentXML = new XElement("student");

            studentXML.Add(new XAttribute("name", student.Name));

            studentXML.Add(new XAttribute("gender", student.Gender));

            studentXML.Add(new XAttribute("PhoneNumber", student.PhoneNumber));

            var exams = new XElement("exams");


            foreach (var element in student.Exams)
            {
                var newExam = new XElement("exam");

                newExam.Add(new XAttribute("examName", element.Name));
                newExam.Add(new XAttribute("dateTaken", element.DateTaken));
                newExam.Add(new XAttribute("grade", element.Grade));

                exams.Add(newExam);

            }

            studentXML.Add(exams);


            xmlDocument.Add(studentXML);
            xmlDocument.Save("../../students.xml");

        }
    }
}
