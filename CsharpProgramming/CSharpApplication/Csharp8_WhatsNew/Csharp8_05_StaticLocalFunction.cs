using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        int Test1()
        {
            int y;
            LocalFunction();
            return y;

            void LocalFunction() => y = 0; // compile time error if you specify static
        }

        int Test2()
        {
            int y = 5;
            int x = 7;
            return Add(x, y);

            static int Add(int left, int right) => left + right;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test2();
        }
        /** output:
        */
    }
}
