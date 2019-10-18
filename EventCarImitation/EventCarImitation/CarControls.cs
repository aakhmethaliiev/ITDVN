using EventCarImitation.Delegates;

namespace EventCarImitation
{
    internal class CarControls
    {
        public event ThrottlePushDelegate ThrottlePush;
        public event BreakPushDelegate BreakPush;
        public event SteeringWheelLeftDelegate SteerLeft;
        public event SteeringWheelRightDelegate SteerRight;

        public void OnThrottlePush()
        {
            ThrottlePush?.Invoke();
        }

        public void OnBreakPush()
        {
            BreakPush?.Invoke();
        }

        public void OnSteerLeft()
        {
            SteerLeft?.Invoke();
        }

        public void OnSteerRight()
        {
            SteerRight?.Invoke();
        }
    }
}
