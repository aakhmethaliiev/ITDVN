using System;
using System.Collections.Generic;

namespace SysCollPurchases
{
    internal class Program
    {
        private static void Main()
        {
            var purchases = new Dictionary<Customer, Category>
            {
                {new Customer("Anton"), Category.Notebooks},
                {new Customer("Dmitro"), Category.Telephones},
                {new Customer("Oleg"), Category.Other},
                {new Customer("Oleg"), Category.Telephones}
            };

            foreach (var purchase in purchases)
            {
                Console.WriteLine($"{purchase.Value} : {purchase.Key.FullName}");
            }

            Console.ReadKey();
        }
    }
}
