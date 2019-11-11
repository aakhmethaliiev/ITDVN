using System;
using System.Threading;

namespace ThreaCharacterChain
{
    class Program
    {
        static object param = new object();

        static int[] GetArray()
        {
            var rand = new Random();
            return new int[rand.Next(5, 10)];
        }

        static int[] GetElements(int[] array)
        {
            var rand = new Random();
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 2);
            }

            return array;
        }

        static void PrintArray(int[] array)
        {
            var rand = new Random();
            var startX = Console.CursorLeft;
            var startY = Console.CursorTop;
            array = GetElements(array);
            while (true)
            {                
                lock (param)
                {
                    array = GetElements(array);
                    Clear(startX, ref startY);
                    for (var i = 0; i < array.Length; i++)
                    {
                        ConsoleTextColor(i, array.Length);
                        Console.Write(array[i]);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        if (Console.CursorTop + 1 < 30)
                        {
                            Console.SetCursorPosition(startX, Console.CursorTop + 1);
                        }
                        else
                        {
                            Console.SetCursorPosition(startX, 0);
                        }
                    }
                }
                Thread.Sleep(100);
            }
        }

        static void ConsoleTextColor(int i, int length)
        {
            switch (length - i)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
        }

        static void Clear(int startX, ref int startY)
        {
            if (startY + 1 < 30)
            {
                Console.SetCursorPosition(startX, startY);
                Console.WriteLine("  ");
                Console.SetCursorPosition(startX, startY + 1);
                startY++;
            }
            else
            {
                Console.SetCursorPosition(startX, startY);
                Console.WriteLine("  ");
                Console.SetCursorPosition(startX, 0);
                startY = 0;
            }
        }

        static void ArrayService()
        {

            var rand = new Random();
            var array = GetArray();
            Console.SetCursorPosition(rand.Next(120), rand.Next(30));
            PrintArray(array);

        }

        static void Main()
        {
            Thread thread;
            for (var i = 0; i < 200; ++i)
            {
                thread = new Thread(ArrayService);
                thread.Start();
                Thread.Sleep(200);
            }
            Console.ReadKey();
        }
    }
}
