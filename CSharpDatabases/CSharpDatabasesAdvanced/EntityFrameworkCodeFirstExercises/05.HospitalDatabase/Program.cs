using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using _05.HospitalDatabase.Interfaces;
using _05.HospitalDatabase.Models;

namespace _05.HospitalDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            HospitalContext context = new HospitalContext();

            try
            {
                //Patient patient = new Patient("David", "Blare", "Sofia", DateTime.Now, true);


                //Diagnose diagnose = new Diagnose("nothing", "alsonothing",  patient)
                //{
                //    Comments = "Yesss"
                //};

                //Doctor doctor = new Doctor("Dr.Drake", "Specialty");

                //Medicament medicament = new Medicament("Psihodil");


                //Visitation visitation = new Visitation(DateTime.Now, "The Best Patient", doctor, patient);

                //context.Diagnoses.Add(diagnose);
                //context.Medicaments.Add(medicament);
                //context.Patients.Add(patient);
                //context.Visitations.Add(visitation);
                //context.Doctors.Add(doctor);

                //context.SaveChanges();

                var patients = context.Patients.Where(x => x.FirstName == "David");

                foreach (var element in patients)
                {
                    Console.WriteLine(element.LastName);
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (DbEntityValidationResult dbEntityValidationResult in ex.EntityValidationErrors)
                {
                    foreach (DbValidationError dbValidationError in dbEntityValidationResult.ValidationErrors)
                    {
                        Console.WriteLine($"{dbValidationError.PropertyName} {dbValidationError.ErrorMessage}");
                    }
                }
            }


        }
    }
}
