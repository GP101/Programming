// https://www.c-sharpcorner.com/article/top-10-new-features-of-c-sharp-7-with-visual-studio-2017/
using static System.Console;

namespace RefReturnsAndRefLocals
{
    class Program
    {
        public ref int GetFirstOddNumber(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    return ref numbers[i]; //returning as reference  
                }
            }
            throw new Exception("odd number not found");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] x = {
                2,
                4,
                62,
                54,
                33,
                55,
                66,
                71,
                92
            };
            ref int oddNum = ref p.GetFirstOddNumber(x); //storing as reference  
            WriteLine($"{oddNum}");
            oddNum = 35;
            for (int i = 0; i < x.Length; i++)
            {
                Write($"{x[i]},");
            }
            ReadKey();
        }
        /** output:
            33
            2,4,62,54,35,55,66,71,92,
        */
    }
}