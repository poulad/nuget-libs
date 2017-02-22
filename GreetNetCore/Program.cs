using System;
using Testy.Greeting;

namespace GreetNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeter = new Greeter();
            greeter.Greet();

            Console.Write("\n\nPress enter to exit...");
            Console.ReadLine();
        }
    }
}