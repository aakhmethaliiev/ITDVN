using System;

namespace EqualsBlock
{
    internal class Program
    {
        private static void Main()
        {
            var block1 = new Block(2, 2, 2, 2);
            var block2 = new Block(2, 2, 2, 2);
            Console.WriteLine($"Block1 - {block1};\n" +
                              $"Block2 - {block2};\n");
            Console.WriteLine($"Block1 HashCode - {block1.GetHashCode()};\n" +
                              $"Block2 HashCode - {block2.GetHashCode()};\n");
            Console.WriteLine($"Equals - {block1.Equals(block2)}");
            Console.ReadKey();
        }
    }
}
