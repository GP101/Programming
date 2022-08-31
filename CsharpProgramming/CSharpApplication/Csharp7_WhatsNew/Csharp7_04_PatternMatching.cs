// https://www.c-sharpcorner.com/article/top-10-new-features-of-c-sharp-7-with-visual-studio-2017/
using static System.Console;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1   
            var myData = "Custom Data";
            var myData2 = myData is not string ? "Not a String" : "String";
            var myData3 = myData is string a ? a : "Not a String";
            WriteLine(myData2);
            WriteLine(myData3);
            //Example 2   
            var x = 10;
            dynamic y = 0b1001;
            var sum = y is int ? $"{y * x}" : "Invalid data";
            WriteLine(sum);
        }
        /** output:
            String
            Custom Data
            90
        */
    }
}
