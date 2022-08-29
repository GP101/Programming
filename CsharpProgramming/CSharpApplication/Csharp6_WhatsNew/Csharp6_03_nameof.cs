using System;
using System.Xml.Linq;

class Program
{
    string name = "";
    public string Name
    {
        get => name;
        set
        {
            name = value ?? throw new ArgumentNullException(nameof(value), $"{nameof(Name)} cannot be null");
            //Console.WriteLine(nameof(value));
        }
    }
    void Test()
    {
        //try
        //{
        Name = null;
        //}
        //catch(Exception ex)
        //{
        //}
        //Name = "Hello";
    }

    static void Main()
    {
        Console.WriteLine(nameof(System.Collections.Generic));  // output: Generic
        Console.WriteLine(nameof(List<int>));  // output: List
        Console.WriteLine(nameof(List<int>.Count));  // output: Count
        Console.WriteLine(nameof(List<int>.Add));  // output: Add

        var numbers = new List<int> { 1, 2, 3 };
        Console.WriteLine(nameof(numbers));  // output: numbers
        Console.WriteLine(nameof(numbers.Count));  // output: Count
        Console.WriteLine(nameof(numbers.Add));  // output: Add    }

        Program p = new Program();
        p.Test();
    }
    /** output:
        Generic
        List
        Count
        Add
        numbers
        Count
        Add
        Unhandled exception. System.ArgumentNullException: Name cannot be null (Parameter 'value')
           at Program.set_Name(String value) in D:\github\Programming\CsharpProgramming\CSharpApplication\Program.cs:line 12
           at Program.Test() in D:\github\Programming\CsharpProgramming\CSharpApplication\Program.cs:line 20
           at Program.Main() in D:\github\Programming\CsharpProgramming\CSharpApplication\Program.cs:line 41
    */
}