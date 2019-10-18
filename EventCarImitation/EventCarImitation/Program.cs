using System;

namespace EventCarImitation
{
    internal class Program
    {
        private static void Main()
        {
            var carControls = CarControlInit.GetCarControls();
            do
            {
                ReadKeyCase(Console.ReadKey(), carControls);
            } while (true);
        }

        public static void ReadKeyCase(ConsoleKeyInfo consoleKey, CarControls carControls)
        {
            switch (consoleKey.Key)
            {
                case ConsoleKey.DownArrow:
                    carControls.OnBreakPush();
                    break;
                case ConsoleKey.UpArrow:
                    carControls.OnThrottlePush();
                    break;
                case ConsoleKey.LeftArrow:
                    carControls.OnSteerLeft();
                    break;
                case ConsoleKey.RightArrow:
                    carControls.OnSteerRight();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
