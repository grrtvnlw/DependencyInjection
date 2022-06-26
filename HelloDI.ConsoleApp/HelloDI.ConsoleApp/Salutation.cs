using System;

namespace HelloDI.ConsoleApp
{
    internal class Salutation
    {
        private IMessageWriter _writer;

        public Salutation(IMessageWriter writer)
        {
            if (writer == null) throw new ArgumentNullException("writer");

            _writer = writer;
        }

        public void Exclaim()
        {
            _writer.Write("Hello DI!");
        }
    }
}