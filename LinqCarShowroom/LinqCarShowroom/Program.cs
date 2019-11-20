using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqCarShowroom
{
    internal class Program
    {
        private static void Main()
        {
            var cars = new List<Car>
            {
                new Car("BMW", "720LI", 2019, "Black"),
                new Car("Ford", "Focus", 2015, "Blue"),
                new Car("Skoda", "Octavia RS", 2017, "White"),
                new Car("Audi", "A8", 2018, "Black"),
            };

            var orders = new List<Order>
            {
                new Order("720LI", "Anton Akhmethaliiev", "+380731314056"),
                new Order("A8", "Vova Dronenko", "+380673245476"),
            };

            var query = from car in cars
                join order in orders
                    on car.Model equals order.Model
                orderby order.FullName
                select new
                {
                    FullName = order.FullName,
                    Telephone = order.Telephone,
                    Manufacturer = car.Manufacturer,
                    Model = car.Model,
                    IssueYear = car.IssueYear,
                    Color = car.Color
                };

            foreach (var order in query)
            {
                Console.WriteLine($"Purchaser:\n" +
                                  $"Full name - {order.FullName}\n" +
                                  $"Telephone - {order.Telephone}\n" +
                                  $"\nPurchased car:\n" +
                                  $"Manufacturer - {order.Manufacturer}\n" +
                                  $"Model - {order.Model}\n" +
                                  $"IssueYear - {order.IssueYear}\n" +
                                  $"Color - {order.Color}\n");
            }

            Console.ReadKey();
        }
    }
}
