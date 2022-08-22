using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int> { 1,3,5,7,9,2,4,6,8,10};
            Parallel.For( 0, 5, (i) => Console.WriteLine(i));

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        static void DoSomeWork(int id, int sleepTime)
        {
            Console.WriteLine("task {0} is beginning", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} has completed", id);
        }

        static void DoSomeWork2(int id, int sleepTime)
        {
            Console.WriteLine("task {0} is beginning more work", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} has completed more work", id);
        }
    }
    /*
        0
        3
        4
        1
        2
        Press any key to quit    
    */
}