// https://www.c-sharpcorner.com/article/top-10-new-features-of-c-sharp-7-with-visual-studio-2017/
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        string s = "26-Nov-2016";
        if (DateTime.TryParse(s, out DateTime date))
        {
            WriteLine(date);
        }
        WriteLine(date);
    }
    /** output:
        2016-11-26 오전 12:00:00
        2016-11-26 오전 12:00:00
    */
}