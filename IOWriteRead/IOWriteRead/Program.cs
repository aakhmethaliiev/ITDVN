using System;
using System.IO;

namespace IOWriteRead
{
    internal class Program
    {
        private static void Main()
        {
            var file = new FileInfo(@"Text.txt");
            var writer = file.CreateText();

            writer.WriteLine("Some text.");

            writer.Close();
            Console.WriteLine("Data writed in file.");
            Console.ReadKey();

            var reader = file.OpenText();
            string input;

            while ((input = reader.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }

            Console.ReadKey();
        }
    }
}
