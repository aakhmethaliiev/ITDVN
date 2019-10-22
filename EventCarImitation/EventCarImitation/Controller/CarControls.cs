using System;

namespace EventCarImitation.Controller
{
    public class CarControls
    {
        public void ThrottlePush()
        {
            Console.WriteLine("The car goes faster.");
        }

        public void BreakPush()
        {
            Console.WriteLine("The car goes slower.");
        }

        public void SteeringWheelRight()
        {
            Console.WriteLine("The car goes to the right.");
        }

        public void SteeringWheelLeft()
        {
            Console.WriteLine("The car goes to the left.");
        }
    }
}
