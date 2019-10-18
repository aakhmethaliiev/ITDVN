namespace EventCarImitation
{
    public static class CarControlInit
    {
        public static CarControls GetCarControls()
        {
            var carControls = new CarControls();
            carControls = EventSnap.GetCarControlsSnap(carControls);
            return carControls;
        }
    }
}
