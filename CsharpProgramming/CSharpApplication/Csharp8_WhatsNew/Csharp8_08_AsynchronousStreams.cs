using System.Threading.Tasks;
using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        public static async System.Collections.Generic.IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }

        public static async void TestAwaitFor()
        {
            await foreach (var number in GenerateSequence())
            {
                Console.Write($"{number},");
            }
        }

        static void Main(string[] args)
        {
            TestAwaitFor();
            Console.ReadKey();
        }
        /** output:
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,
        */
    }
}
