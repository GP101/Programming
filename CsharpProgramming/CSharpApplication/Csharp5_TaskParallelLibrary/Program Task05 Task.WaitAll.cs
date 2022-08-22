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
            var t1 = Task.Factory.StartNew(() => DoSomeWork(1, 1500))
                .ContinueWith( (prevTask)=> DoSomeWork2(1,1000) );
            var t2 = new Task(() => DoSomeWork(2, 3000));
            t2.Start();
            var t3 = new Task(() => DoSomeWork(3, 1000));
            t3.Start();
            var taskList = new List<Task> { t1, t2, t3 };
            Task.WaitAll(taskList.ToArray());

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
        task 1 is beginning
        task 3 is beginning
        task 2 is beginning
        task 3 has completed
        task 1 has completed
        task 1 is beginning more work
        task 1 has completed more work
        task 2 has completed
        Press any key to quit    
    */
}