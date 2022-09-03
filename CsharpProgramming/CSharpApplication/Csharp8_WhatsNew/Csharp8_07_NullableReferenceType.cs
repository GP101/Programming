using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string? nullableString = null;
            Console.WriteLine(nullableString.Length); // Warning CS8602  Dereference of a possibly null reference.
        }
    }
    /** output message:
        Warning CS8602  Dereference of a possibly null reference.
    */
}
