using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Example
{
    class Program
    {
        static async Task<int> AsyncTest()
        {
            var task = new Task<int>(() =>
            {
                int sum = 0;
                for (int i = 0; i <= 10; i++)
                {
                    sum += i;
                    Thread.Sleep(100);
                }
                return sum;
            });
            task.Start();
            Console.WriteLine("before await task");
            await task; // unblocking wait, other thread can continue it's task.
            Console.WriteLine(task.Result);
            Console.WriteLine("before return task");
            return task.Result + 100; // will signal task.Wait()
        }
        static void Main(string[] args)
        {
            var task = AsyncTest();

            Console.WriteLine("before task.Wait()");
            task.Wait(); // wait task return
            Console.WriteLine("after task.Wait()");

            int result = task.Result; // get return value of task
            Console.WriteLine(result);
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            /** output:
                before await task
                before task.Wait() // after 1 second
                55
                before return task
                after task.Wait()
                155
                Press any key...
            */
        }
    }
}
