using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    interface IWriteLine
    {
        public void WriteLine()
        {
            Console.WriteLine("Base WriteLine");
        }
    }

    class KWriteLine : IWriteLine
    {
        //public void WriteLine()
        //{
        //    Console.WriteLine("Derived WriteLine");
        //}
        public void WriteLine2()
        {
            Console.WriteLine("Derived WriteLine2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KWriteLine kwl = new KWriteLine();
            //kwl.WriteLine();
            kwl.WriteLine2();
            IWriteLine iwl = kwl;
            iwl.WriteLine();
        }
    }
    /** output:
        Derived WriteLine2
        Base WriteLine
    */
}
