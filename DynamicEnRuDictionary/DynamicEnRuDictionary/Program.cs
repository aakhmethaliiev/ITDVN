using System;

namespace DynamicEnRuDictionary
{
    internal class Program
    {

        private static void Main()
        {
            Console.WriteLine("En-Ru dictionary\n");
            foreach (dynamic word in EnRuDictionary.Dictionary())
            {
                Console.WriteLine($"{word.Key} - {word.Value};");
            }

            Console.ReadKey();
        }

    }
}