using System;

namespace EventCarImitation
{
    public static class EventHandlers
    {
        public static void ThrottlePushHandler()
        {
            Console.WriteLine("The car goes faster.");
        }
        
        public static void BreakPushHandler()
        {
            Console.WriteLine("The car goes slower.");
        }
        
        public static void SteeringWheelRightHandler()
        {
            Console.WriteLine("The car goes to the right.");
        }
        
        public static void SteeringWheelLeftHandler()
        {
            Console.WriteLine("The car goes to the left.");
        }
    }
}
