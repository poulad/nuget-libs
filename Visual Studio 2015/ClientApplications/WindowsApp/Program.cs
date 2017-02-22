using System;
using Testy.Greeting;

namespace WindowsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ".NET 4.6";

            var greeter = new WindowsGreeter();
            greeter.Greet();
        }
    }
}
