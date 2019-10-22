namespace EventCarImitation
{
    internal class Program
    {
        private static void Main()
        {
            var keyEvents = new KeyEvents();
            do
            {
                keyEvents.KeyHandler();
            } while (true);
        }
    }
}
