using static System.Console;

// https://www.c-sharpcorner.com/article/top-10-new-features-of-c-sharp-7-with-visual-studio-2017/
class Program
{
    static void Main(string[] args)
    {
        void Add(int x, int y)
        {
            WriteLine($"Sum of {x} and {y} is : {x + y}");
        }
        void Multiply(int x, int y)
        {
            WriteLine($"Multiply of {x} and {y} is : {x * y}");
            Add(30, 10);
        }
        Add(20, 50);
        Multiply(20, 50);
    }
    /** output:
        Sum of 20 and 50 is : 70
        Multiply of 20 and 50 is : 1000
        Sum of 30 and 10 is : 40
    */
}
