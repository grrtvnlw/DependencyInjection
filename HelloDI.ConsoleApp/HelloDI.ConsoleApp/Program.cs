using System;

namespace HelloDI.ConsoleApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            IMessageWriter writer = new ConsoleMessageWriter();
            var salutation = new Salutation(writer);
            salutation.Exclaim();
        }
    }
}
