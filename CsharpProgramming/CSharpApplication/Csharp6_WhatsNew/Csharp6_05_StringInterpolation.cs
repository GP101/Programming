using System;
using System.Reflection;
using static System.Linq.Enumerable;
using System;

class Program
{
    void Test()
    {
    }

    static void Main()
    {
        string expected = "hello";
        int received = 99;
        Console.WriteLine($"Expected: {expected} Received: {received}.");

        var stamp = $"Timestamp: {DateTime.Now.ToString("s", System.Globalization.CultureInfo.InvariantCulture)}";

        var values = new int[] { 1, 2, 3, 4, 12, 123456 };
        foreach (var s in values.Select(i => $"The value is {i,10:N2}."))
        {
            Console.WriteLine(s);
        }
        Console.WriteLine($"Minimum is {values.Min(i => i):N2}.");
    }
    /** output:
        Expected: hello Received: 99.
        The value is       1.00.
        The value is       2.00.
        The value is       3.00.
        The value is       4.00.
        The value is      12.00.
        The value is 123,456.00.
        Minimum is 1.00.
    */
}
