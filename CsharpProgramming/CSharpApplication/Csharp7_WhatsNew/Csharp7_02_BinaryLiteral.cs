// https://www.c-sharpcorner.com/article/top-10-new-features-of-c-sharp-7-with-visual-studio-2017/
using static System.Console;

namespace BinaryLiteral
{
    class Program
    {
        static void Main(string[] args)
        {
            //Represent 50 in decimal, hexadecimal & binary  
            int a = 50; // decimal representation of 50  
            int b = 0X32; // hexadecimal representation of 50  
            int c = 0B110010; //binary representation of 50  
            //Represent 100 in decimal, hexadecimal & binary  
            int d = 50 * 2; // decimal represenation of 100   
            int e = 0x32 * 2; // hexadecimal represenation of 100  
            int f = 0b110010 * 2; //binary represenation of 100  
            WriteLine($"a: {a:0000} b: {b:0000} c: {c:0000}");
            WriteLine($"d: {d:0000} e: {e:0000} f: {f:0000}");
        }
        /** output:
            a: 0050 b: 0050 c: 0050
            d: 0100 e: 0100 f: 0100
        */
    }
}