using System.Collections.Generic;
using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);

            Console.WriteLine(string.Join(" ", numbers)); // output: 17 17
            Console.WriteLine(i); // output: 17
        }
        /** output:
            17 17
            17
        */
    }
}