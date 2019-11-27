using System;
using System.IO;
using System.IO.IsolatedStorage;

namespace IsolatedStorage
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter name of file for isolated storage - ");
            var fileName = Console.ReadLine();
            var userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
            var userStream = new IsolatedStorageFileStream(fileName, FileMode.Create, userStorage);
            Console.WriteLine("File was created.");
            var userWriter = new StreamWriter(userStream);
            Console.Write("Enter text for created file - ");
            var text = Console.ReadLine();
            userWriter.WriteLine(text);
            userWriter.Close();
            Console.WriteLine("Text was added.");
            Console.ReadKey();
        }
    }
}
