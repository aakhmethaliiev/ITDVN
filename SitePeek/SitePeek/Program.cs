using System;
using System.IO;

namespace SitePeek
{
    internal class Program
    {
        private static void Main()
        {
            var searchService = new SearchService(@"https://www.shkaflon.ru/");
            
            var file = new FileInfo(@"Elements.txt");
            var writer = file.CreateText();

            writer.WriteLine(searchService.GetLinks());
            writer.WriteLine(searchService.GetTelephones());
            writer.WriteLine(searchService.GetEmails());

            writer.Close();

            Console.WriteLine("Elements are writed in file.");
            Console.ReadKey();
        }
    }
}
