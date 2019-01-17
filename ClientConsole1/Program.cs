using System;
using System.Globalization;

namespace ClientConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new MyLibrary.MyService1(Console.Out);

            x.WriteMessage("This is cool.");

            Console.ReadLine();
        }
    }
}
