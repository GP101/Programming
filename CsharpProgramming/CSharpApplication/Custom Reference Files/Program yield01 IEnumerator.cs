﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int value in GetNextValue1())
            {
                Console.WriteLine("value = {0}", value);
            }
            IEnumerator<object> enumerator = GetNextValue1().GetEnumerator();
            while (enumerator.MoveNext())
            {
                object item = enumerator.Current;
                Console.WriteLine("value2 = {0}", item);
            }
            IEnumerator<object> enumerator2 = GetNextValue2();
            while (enumerator2.MoveNext())
            {
                object item = enumerator2.Current;
                Console.WriteLine("value3 = {0}", item);
                if (item.ToString() == "hello")
                    Console.WriteLine("First case");
                else if (item.ToString() == "wonderful")
                    Console.WriteLine("Second case");
                else if (item.ToString() == "world")
                    Console.WriteLine("Third case");
            }
        }

        static IEnumerable<object> GetNextValue1()
        {
            yield return 1;
            yield return 3;
            yield return 5;
            yield break;
        }
        static IEnumerator<object> GetNextValue2()
        {
            yield return "hello";
            yield return "wonderful";
            yield return "world";
            yield break;
        }
    }
}

/** output
value = 1
value = 3
value = 5
value2 = 1
value2 = 3
value2 = 5
value3 = hello
First case
value3 = wonderful
Second case
value3 = world
Third case
계속하려면 아무 키나 누르십시오 . . .
*/
