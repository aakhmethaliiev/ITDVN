namespace EventCarImitation
{
    internal class Program
    {
        private static void Main()
        {
            var keyEvents = new CarEventController();
            do
            {
                keyEvents.KeyHandler();
            } while (true);
        }
    }
}
