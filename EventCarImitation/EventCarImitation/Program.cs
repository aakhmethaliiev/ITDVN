using System;

namespace EventCarImitation
{
    internal class Program
    {
        private static void Main()
        {
            var carControls = new CarControls();
            carControls = EventSnap.GetCarControlsSnap(carControls);
            do
            {
                var choose = Console.ReadKey();
                switch (choose.Key)
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

            } while (true);
        }
    }
}
