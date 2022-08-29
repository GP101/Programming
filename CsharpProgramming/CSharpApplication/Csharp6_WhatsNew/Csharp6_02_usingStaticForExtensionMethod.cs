using static System.Linq.Enumerable;
using static System.String;

class Program
{
    static void Main()
    {
        var values = new int[] { 1, 2, 3, 4 };
        var evenValues = values.Where(i => i % 2 == 0);
        System.Console.WriteLine(Join(",", evenValues));
    }
    /** output:
        2,4
    */
}