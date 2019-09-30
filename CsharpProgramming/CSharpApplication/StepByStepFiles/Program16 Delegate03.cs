﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

class Program1
{
    delegate void HelloDelegate();

    static void Main( string[] args )
    {
        HelloDelegate hello1 = new HelloDelegate( SayHello );
        hello1 += new HelloDelegate(SayHello2);
        hello1();
    }
    static void SayHello()
    {
        Console.WriteLine( "Hello World" );
    }
    static void SayHello2()
    {
        Console.WriteLine( "Hello World2" );
    }
    static void Test( HelloDelegate del )
    {
        del();
    }
}
