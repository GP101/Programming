using System;
using System.Linq;
using System.IO;
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
            var t1 = new Task(() => {
                Console.WriteLine("task 1 is beginning");
                Thread.Sleep(1000);
                Console.WriteLine("task 1 has completed");
            });
            t1.Start();
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
        /*
            Press any key to quit
            task 1 is beginning
            task 1 has completed        
        */
    }
}