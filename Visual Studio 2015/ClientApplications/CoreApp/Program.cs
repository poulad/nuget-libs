using System;
using Testy.Greeting;

namespace CoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = ".NET Core";

            var greeter = new Greeter();
            greeter.Greet();
        }
    }
}
