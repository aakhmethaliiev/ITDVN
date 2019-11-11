using System;
using System.Threading;

namespace L13EThreadRecurs
 
{
    class Program
    {
        static void WriteHello()
        {
            Console.WriteLine("Hello");
            Thread.Sleep(500);
            var thrad = new Thread(WriteHello);
            thrad.Start();
        }

        static void Main()
        {
            var thrad = new Thread(WriteHello);
            thrad.Start();
        }
    }
}
