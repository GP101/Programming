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
            var source = new CancellationTokenSource();
            try
            {
                var t1 = Task.Factory.StartNew(() => DoSomeWork(1, 1000, source.Token))
                    .ContinueWith((prevTask) => DoSomeWork2(2, 1000));
                Thread.Sleep(100);
                source.Cancel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
            }


            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        static void DoSomeWork(int id, int sleepTime, CancellationToken token)
        {
            Console.WriteLine("task {0} is beginning", id);
            Thread.Sleep(sleepTime);
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation requested");
                token.ThrowIfCancellationRequested();
            }
            Console.WriteLine("task {0} has completed", id);
        }

        static void DoSomeWork2(int id, int sleepTime)
        {
            Console.WriteLine("task {0} is beginning more work", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} has completed more work", id);
        }
        /*
            task 1 is beginning
            Press any key to quit
            Cancellation requested
            task 2 is beginning more work
            task 2 has completed more work        
        */
    }
}