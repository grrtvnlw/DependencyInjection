using System;

namespace HelloDI.ConsoleApp
{
    internal class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}