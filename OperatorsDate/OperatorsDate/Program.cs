using System;

namespace OperatorsDate
{
    internal class Program
    {
        private static void Main()
        {
            var date1 = new Date(2019, 9, 26);
            var date2 = new Date(2019, 5, 20);
            Console.WriteLine($"Date 1 : {date1}");
            Console.WriteLine($"Date 2 : {date2}\n");
            var days = date2 - date1;
            Console.WriteLine($"Number of days between 2 dates - {days}\n");
            var newDate = date1 + 1000;
            Console.WriteLine($"Old date : {date1}");
            Console.WriteLine($"New date with increase days : {newDate}");
            Console.ReadKey();
        }
    }
}
