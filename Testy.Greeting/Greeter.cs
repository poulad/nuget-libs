using System;
using Testy.Greeting.Abstractions;

namespace Testy.Greeting
{
    public class Greeter : IGreeter
    {
        public static string Message => "Hello world from .NET Standard library";

        public void Greet()
        {
            Console.WriteLine(Message);
        }
    }
}
