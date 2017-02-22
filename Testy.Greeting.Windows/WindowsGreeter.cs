using System;
using Testy.Greeting.Abstractions;

namespace Testy.Greeting
{
    public class WindowsGreeter : IGreeter
    {
        public static string Message => "Hello world from Full .NET on Windows";

        public void Greet()
        {
            Console.WriteLine(Message);
        }
    }
}
