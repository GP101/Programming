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
                    Console.WriteLine("\tSum = {0}", sum);
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

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("i = {0}", i);
                Thread.Sleep(100);
            }
            Console.WriteLine("before task.Wait()");
            task.Wait(); // wait task return
            Console.WriteLine("after task.Wait()");

            int result = task.Result; // get return value of task
            Console.WriteLine(result);
            Console.WriteLine("Press Any Key...");
            Console.ReadKey();
            /** output:
                before await task
                before task.Wait()
                55
                before return task
                after task.Wait()
                155
            */
            /*
                before await task
                        Sum = 0
                i = 0
                i = 1
                        Sum = 1
                        Sum = 3
                i = 2
                i = 3
                        Sum = 6
                i = 4
                        Sum = 10
                i = 5
                        Sum = 15
                i = 6
                        Sum = 21
                        Sum = 28
                i = 7
                i = 8
                        Sum = 36
                i = 9
                        Sum = 45
                i = 10
                        Sum = 55
                i = 11
                55
                before return task
                i = 12
                i = 13
                i = 14
                i = 15
                i = 16
                i = 17
                i = 18
                i = 19
                before task.Wait()
                after task.Wait()
                155
            */
        }
    }
}
