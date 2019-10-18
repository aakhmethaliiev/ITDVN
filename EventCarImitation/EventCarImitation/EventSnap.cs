namespace EventCarImitation
{
    internal static class EventSnap
    {
        public static CarControls GetCarControlsSnap(CarControls carControls)
        {
            carControls.ThrottlePush += EventHandlers.ThrottlePushHandler;
            carControls.BreakPush += EventHandlers.BreakPushHandler;
            carControls.SteerLeft += EventHandlers.SteeringWheelLeftHandler;
            carControls.SteerRight += EventHandlers.SteeringWheelRightHandler;

            return carControls;
        }
    }
}
