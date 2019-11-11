using System;

namespace EventCarImitation
{
    internal class CarEventController
    {
        private event Action ThrottlePush;
        private event Action BreakPush;
        private event Action SteerLeft;
        private event Action SteerRight;

        public CarEventController()
        {
            var carControls = new CarControls();
            ThrottlePush += carControls.ThrottlePush;
            BreakPush += carControls.BreakPush;
            SteerLeft += carControls.SteeringWheelLeft;
            SteerRight += carControls.SteeringWheelRight;
        }

        public void KeyHandler()
        {
            var consoleKey = Console.ReadKey();
            switch (consoleKey.Key)
            {
                case ConsoleKey.DownArrow:
                    DownArrow();
                    break;
                case ConsoleKey.UpArrow:
                    UpArrow();
                    break;
                case ConsoleKey.LeftArrow:
                    LeftArrow();
                    break;
                case ConsoleKey.RightArrow:
                    RightArrow();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
        }

        private void UpArrow()
        {
            ThrottlePush?.Invoke();
        }

        private void DownArrow()
        {
            BreakPush?.Invoke();
        }

        private void LeftArrow()
        {
            SteerLeft?.Invoke();
        }

        private void RightArrow()
        {
            SteerRight?.Invoke();
        }
    }
}
