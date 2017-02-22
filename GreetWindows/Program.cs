using System;
using Testy.Greeting;

namespace GreetWindows
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeter = new WindowsGreeter();
            greeter.Greet();

            Console.Write("\n\nPress enter to exit...");
            Console.ReadLine();
        }
    }
}
