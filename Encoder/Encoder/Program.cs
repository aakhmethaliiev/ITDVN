using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Encoder
{
    internal class Program
    {
        /// <summary> Prepositions in English language. </summary>
        private const string Prepositions = " at| on| in| about| above| below| after| before| by| for| from| of| since| to| with|" +
                                            " At| On| In| About| Above| Below| After| Before| By| For| From| Of| Since| To| With";

        private static void Main()
        {
            var file = new FileInfo(@"Text.txt");

            var reader = file.OpenText();
            var stringBuilder = new StringBuilder();
            string input;

            while ((input = reader.ReadLine()) != null)
            {
                stringBuilder.Append(input);
            }

            reader.Close();
            var text = stringBuilder.ToString();

            text = Regex.Replace(text, Prepositions, " GAV!");

            var writer = file.CreateText();

            writer.WriteLine(text);
            writer.Close();

            Console.WriteLine("Text are replaced.");

            Console.ReadKey();
        }
    }
}
