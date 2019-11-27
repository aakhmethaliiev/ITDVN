using System;

namespace FileSearchCompression.FileServices
{
    internal class FileManager
    {
        /// <summary> Service that working with files. </summary>
        private readonly IFileService _fileService;

        /// <summary> Full path to target file. </summary>
        private string _fileName;

        /// <summary> Default constructor. </summary>
        public FileManager()
        {
            _fileService = new FileService();
        }

        /// <summary> Search file in target driver. </summary>
        public void SearchFile()
        {
            var drivers = GetDrivers.GetListOfDrivers();
            var body = new string[drivers.Count + 1];
            body[0] = "Select target driver.";
            for (var i = 1; i < body.Length; i++)
            {
                body[i] = drivers[i - 1].ToString();
            }

            var targetDriver = Menu.CreateMenuStr(body);

            Console.Write("\nEnter name of targer file - ");
            _fileName = Console.ReadLine();

            var searchResult = _fileService.SearchFile(targetDriver, _fileName);
            if (searchResult)
            {
                Console.WriteLine($"\nFile {_fileName} was founded!");
            }
            else
            {
                Console.WriteLine($"\nFile {_fileName} wasnt founded!");
            }

        }

        /// <summary> Compression target file. </summary>
        public void Compression()
        {
            Console.WriteLine("\nPress any key for compression this file.");
            Console.ReadKey();

            _fileService.Compression(_fileName);
            Console.WriteLine("\nFile was compressed!");
        }
    }
}