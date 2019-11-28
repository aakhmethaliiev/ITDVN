using System;

namespace SitePeek
{
    internal class Program
    {
        private static void Main()
        {
            var searchService = new SearchService(@"https://www.shkaflon.ru/");
            Console.WriteLine(searchService.GetLinks());
            Console.WriteLine(searchService.GetTelephones());
            Console.WriteLine(searchService.GetEmails());
            Console.ReadKey();
        }
    }
}
