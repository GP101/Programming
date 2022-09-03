using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            var words = new string[]
            {
                // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0        }
            Console.WriteLine($"The last word is {words[^1]}");
            // writes "dog"
            var quickBrownFox = words[1..4];
            foreach (string s in quickBrownFox)
                WriteLine(s);
        }
        /** output:
            The last word is dog
            quick
            brown
            fox         
        */
    }
}