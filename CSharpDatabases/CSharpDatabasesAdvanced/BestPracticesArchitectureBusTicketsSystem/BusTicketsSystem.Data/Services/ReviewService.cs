using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.Data.Interfaces;
using BusTicketsSystem.Models;

namespace BusTicketsSystem.Data.Services
{
    public class ReviewService
    {
        private readonly IUnitOfWork unit;

        public ReviewService(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string PublishReview(string[] data)
        {
            int customerId = int.Parse(data[1]);

            decimal grade = decimal.Parse(data[2]);

            string busCompanyName = data[3];

            string content = data[4];

            Customer customer = unit.Customers.GetById(customerId);

            BusCompany busCompany = unit.BusCompanies.Find(x => x.Name == busCompanyName).FirstOrDefault();

            Review review = new Review()
            {
                BusCompany = busCompany,
                Content = content,
                Customer = customer,
                DateAndTimeOfPublishing = DateTime.Now,
                Grade = grade
            };

            unit.Reviews.Add(review);

            unit.Save();

            string result =
                $"Customer {customer.FirstName + " " + customer.LastName} published review for company {busCompanyName}";

            return result;

        }

        public string ReturnReviews(int id)
        {
            var company = this.unit.BusCompanies.Find(x => x.Id == id).FirstOrDefault();

            string result = null;

            foreach (var element in company.ReviewsCollection)
            {
                result += $"{element.Id} {element.Grade} {element.DateAndTimeOfPublishing} {element.Customer.FirstName + " " + element.Customer.LastName} {element.Content}";
            }

            return result;
        }
    }
}
