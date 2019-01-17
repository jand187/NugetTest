using System;
using System.IO;

namespace MyLibrary
{
    public class MyService1
    {
        private readonly TextWriter writer;

        public MyService1(TextWriter writer)
        {
            this.writer = writer ?? Console.Out;

        }

        public void WriteMessage(string message)
        {
            this.writer.WriteLine(message);
        }
    }
}
