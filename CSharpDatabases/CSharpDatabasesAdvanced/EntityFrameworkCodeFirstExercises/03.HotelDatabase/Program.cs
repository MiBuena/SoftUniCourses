using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.HotelDatabase.Enums;
using _03.HotelDatabase.Models;

namespace _03.HotelDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelContext context = new HotelContext();

            Occupancy occupancy = new Occupancy(DateTime.Now, "12323464", "2B", 2.5M, 1M);

            Payment payment = new Payment(DateTime.Now, "234436", DateTime.Now, DateTime.Now, 2.5M, 0.5M);

            Employee employee = new Employee("Robert", "Wilson", "Assistant");

            Room room = new Room("1A", new RoomType(TypeOfARoom.Single), new BedType(TypeOfABed.Single), 2.5M, new RoomStatus(StatusOfARoom.Available));

            Customer customer = new Customer("1235", "Deyan", "Mitsov", "1135324", "Lilia", "24643567");

            context.Customers.Add(customer);
            context.Employees.Add(employee);
            context.Occupancies.Add(occupancy);
            context.Payments.Add(payment);
            context.Rooms.Add(room);

            context.SaveChanges();
        }
    }
}
