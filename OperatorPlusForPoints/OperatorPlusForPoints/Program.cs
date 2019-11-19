using System;

namespace OperatorPlusForPoints
{
    internal class Program
    {
        private static void Main()
        {
            var point1 = new Point(1, 1, 1);
            var point2 = new Point(2, 2, 2);
            var point3 = point1 + point2;

            Console.WriteLine($"Pont 3 = {point3}");

            Console.ReadKey();
        }
    }
}
