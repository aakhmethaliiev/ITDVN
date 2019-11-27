using System;
using FileSearchCompression.FileServices;

namespace FileSearchCompression
{
    internal class Program
    {
        private static void Main()
        {
            var fileManager = new FileManager();

            fileManager.SearchFile();

            fileManager.Compression();
            
            Console.ReadKey();
        }
    }
}
