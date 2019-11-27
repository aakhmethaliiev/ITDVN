using System;

namespace FileSearchCompression
{
    public static class Menu
    {
        private static void WriteLineColor(string str)
        {
            var backgroundColor = Console.BackgroundColor;
            var foregroundColor = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("> {0}", str);
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
        }

        private static void WriteLineDash(string str)
        {
            Console.WriteLine("- {0}", str);
        }

        public static string CreateMenuStr(string[] body)
        {
            ConsoleKeyInfo choose;
            var i = 1;
            var bodyLength = body.Length - 1;
            var resultStr = "";
            do
            {
                Console.Clear();
                if (body[0] != "") Console.WriteLine(body[0]);
                for (var j = 1; j < body.Length; j++)
                {
                    var str = body[j];
                    if (j == i)
                    {
                        WriteLineColor(str);
                        resultStr = str;
                    }
                    else
                    {
                        WriteLineDash(str);
                    }
                }

                Console.WriteLine("\nPress Esc for exit");
                choose = Console.ReadKey();
                switch (choose.Key)
                {
                    case ConsoleKey.DownArrow when i == bodyLength:
                        i = 1;
                        break;
                    case ConsoleKey.DownArrow:
                        ++i;
                        break;
                    case ConsoleKey.UpArrow when i == 1:
                        i = bodyLength;
                        break;
                    case ConsoleKey.UpArrow:
                        --i;
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        return "exit";
                }
            } while (choose.Key != ConsoleKey.Enter);

            return resultStr;
        }

        public static int CreateMenuInt(string[] body)
        {
            ConsoleKeyInfo choose;
            var i = 1;
            var bodyLength = body.Length - 1;
            do
            {
                Console.Clear();
                if (body[0] != "") Console.WriteLine(body[0]);
                for (var j = 1; j < body.Length; j++)
                {
                    if (j == i) WriteLineColor(body[j]);
                    else WriteLineDash(body[j]);
                }

                Console.WriteLine("\nPress Esc for exit");
                choose = Console.ReadKey();
                switch (choose.Key)
                {
                    case ConsoleKey.DownArrow when i == bodyLength:
                        i = 1;
                        break;
                    case ConsoleKey.DownArrow:
                        ++i;
                        break;
                    case ConsoleKey.UpArrow when i == 1:
                        i = bodyLength;
                        break;
                    case ConsoleKey.UpArrow:
                        --i;
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            } while (choose.Key != ConsoleKey.Enter);

            return i-1;
        }

        public static int CreateMenuIntWithoutEsc(string[] body)
        {
            ConsoleKeyInfo choose;
            var i = 1;
            var bodyLength = body.Length - 1;
            do
            {
                Console.Clear();
                if (body[0] != "") Console.WriteLine(body[0]);
                for (var j = 1; j < body.Length; j++)
                {
                    if (j == i) WriteLineColor(body[j]);
                    else WriteLineDash(body[j]);
                }
                //Console.WriteLine("\nPress Esc for exit");
                choose = Console.ReadKey();
                switch (choose.Key)
                {
                    case ConsoleKey.DownArrow when i == bodyLength:
                        i = 1;
                        break;
                    case ConsoleKey.DownArrow:
                        ++i;
                        break;
                    case ConsoleKey.UpArrow when i == 1:
                        i = bodyLength;
                        break;
                    case ConsoleKey.UpArrow:
                        --i;
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            } while (choose.Key != ConsoleKey.Enter);
            return i-1;
        }
    }
}
