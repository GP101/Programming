using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string garbageCollectionTest = "Hello World";
            //for (int i = 1; i < 100000; ++i)
            //{
            //    if (Console.KeyAvailable)
            //    {
            //        if (Console.ReadKey().Key == ConsoleKey.Escape)
            //            break;
            //    }
            //    garbageCollectionTest += "Hello World";
            //}
            //Console.WriteLine(garbageCollectionTest);
            StringBuilder sb = new StringBuilder("Hello World");
            for (int i = 1; i < 100000; ++i)
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                        break;
                }
                sb.Append("Hello World");
            }
            Console.WriteLine(sb);
        }
    }
}
