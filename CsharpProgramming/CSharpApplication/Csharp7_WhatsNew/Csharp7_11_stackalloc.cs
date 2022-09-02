using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 3;
            Span<int> numbers = stackalloc int[length];
            for (var i = 0; i < length; i++)
            {
                numbers[i] = i;
            }
        }
    }
}
