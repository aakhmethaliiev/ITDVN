using System;
using System.Collections;
using System.Linq;

namespace CollectionOfMonths
{
    internal class Program
    {
        private static MonthsCollection<Month> _months;

        private static void Main()
        {
            _months = new MonthsCollection<Month>
            {
                [0] = new Month("January", 1, 31),
                [1] = new Month("February", 2, 28),
                [2] = new Month("March", 3, 31),
                [3] = new Month("April", 4, 30),
                [4] = new Month("May", 5, 31),
                [5] = new Month("June", 6, 30),
                [6] = new Month("July", 7, 31),
                [7] = new Month("August", 8, 31),
                [8] = new Month("September", 9, 30),
                [9] = new Month("October", 10, 31),
                [10] = new Month("November", 11, 30),
                [11] = new Month("November", 12, 31)
            };
            Console.WriteLine("Months:");
            foreach (var month in _months)
            {
                Console.WriteLine($"{month.Index}. {month.MonthName}: {month.DaysNumber};");
            }

            Console.Write("\nEnter number of days - ");
            var days = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"\nMonth with {days} days:");
            var query = from month in _months
                where month.DaysNumber == days
                select new
                {
                    Index = month.Index,
                    MonthName = month.MonthName
                };
            
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Index}. {item.MonthName}");
            }

            Console.ReadKey();
        }
    }
}
