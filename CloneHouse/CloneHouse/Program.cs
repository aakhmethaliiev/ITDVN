using System;

namespace CloneHouse
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("----Surface clone----\n");
            var original = new House("Sheluskova 162", 9);
            var clone = original.Clone();
            Console.WriteLine($"Original: {original}\n" +
                              $"Clone: {clone}\n");
            Console.WriteLine($"Original: {original.GetHashCode()}\n" +
                              $"Clone: {clone.GetHashCode()}\n");
            Console.WriteLine($"Equals: {original.Equals(clone)}\n");

            Console.WriteLine("----Deep clone----\n");
            clone = original.DeepClone();
            Console.WriteLine($"Original: {original.GetHashCode()}\n" +
                              $"Clone: {clone.GetHashCode()}\n");
            Console.WriteLine($"Equals: {original.Equals(clone)}\n");
            
            Console.ReadKey();
        }
    }
}
