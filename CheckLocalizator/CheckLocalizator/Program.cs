using System;
using System.IO;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace CheckLocalizator
{
    internal class Program
    {
        private static void Main()
        {
            var file = new FileInfo("Check.txt");
            CreateCheck(file);

            var reader = file.OpenText();
            string input;
            var stringBuilder = new StringBuilder();

            while ((input = reader.ReadLine()) != null)
            {
                stringBuilder.Append(input);
                stringBuilder.Append("\n");
            }

            var check = stringBuilder.ToString();

            var priceRegex = new Regex( @"(?<price>\d+\.\d\d)");

            var russian = new CultureInfo("ru-RU");
            int dollar = 60;

            foreach (Match match in priceRegex.Matches(check))
            {
                check = check.Replace("$" + match.Value, (double.Parse(match.Value) * dollar).ToString("C", russian));
            }

            var dateRegex = new Regex(@"\d+\/\d+\/\d+\ \d+\:\d+\:\d+\ \S+");

            foreach (Match match in dateRegex.Matches(check))
            {
                check = check.Replace(match.Value, DateTime.Parse(match.Value).ToString("", russian));
            }

            MessageBox.Show(check);

            Console.ReadKey();
        }

        /// <summary> Create check. </summary>
        /// <param name="file"></param>
        private static void CreateCheck(FileInfo file)
        {
            
            if (file.Exists)
            {
                return;
            }

            var writer = file.CreateText();
            writer.WriteLine("Check №1\n");
            writer.WriteLine("Lenovo IdeaPad 330 15ICH - $1000.00\n");
            writer.WriteLine("Lenovo Iphone 6s - $300.00\n");
            writer.WriteLine("Sum - $1300.00\n");
            writer.WriteLine($"Date - {DateTime.Now}");

            writer.Close();
        }
    }
}
