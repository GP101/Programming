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
            var t1 = new Task(() => DoSomeWork(1, 1500));
            t1.Start();
            var t2 = new Task(() => DoSomeWork(2, 3000));
            t2.Start();
            var t3 = new Task(() => DoSomeWork(3, 1000));
            t3.Start();
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        static void DoSomeWork(int id, int sleepTime)
        {
            Console.WriteLine("task {0} is beginning", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} has completed", id);
        }
    }
    /*
        Press any key to quit
        task 1 is beginning
        task 3 is beginning
        task 2 is beginning
        task 3 has completed
        task 1 has completed
        task 2 has completed    
    */
}