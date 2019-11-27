using System;
using System.IO;

namespace Create100Directories
{
    internal class Program
    {
        private static void Main()
        {
            var directory = new DirectoryInfo(@".");
            if (directory.Exists)
            {
                for (var i = 0; i < 100; i++)
                {
                    directory.CreateSubdirectory($@"MyDir\Dir{i}");
                }
            }

            Console.WriteLine("Directories are created. Press any key for delete.");
            Console.ReadKey();

            Directory.Delete(@".\MyDir", true);

            Console.WriteLine("Directories are deleted.");
            Console.ReadKey();
        }
    }
}
