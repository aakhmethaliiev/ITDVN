using System;

namespace GenericsMyList
{
    internal class Program
    {
        private static void Main()
        {
            var list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            var array = list.GetArray();
            foreach (var t in array)
            {
                Console.Write($"{t} ");
            }

            Console.ReadKey();
        }
    }
}
