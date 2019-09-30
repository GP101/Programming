﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace CsharpConsole
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person { Name = "John", Age = 49 };
            p.SayHello("Hello World");
        }
    }

    // Extension method must be defined in a top level static class.
    // _20180501_jintaeks
    public static class Extensions1
    {
        public static void SayHello(this Person person, string msg)
        {
            Console.WriteLine("{0} says {1}", person.Name, msg);
        }
    }
    // output: John says Hello World
}