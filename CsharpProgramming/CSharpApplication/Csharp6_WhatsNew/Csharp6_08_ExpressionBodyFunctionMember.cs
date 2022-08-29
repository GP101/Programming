using System;
using System.Collections.Generic;

class Program
{
    string _firstName = "John";
    string _lastName = "Seo";
    public override string ToString() => $"{_firstName} {_lastName}";

    public void Log(string message) => System.Console.WriteLine(
        $"{DateTime.Now.ToString("s", System.Globalization.CultureInfo.InvariantCulture)}: {message}");

    static void Main(string[] args)
    {
        Program p = new Program();
        p.Log("Hello");
    }
    /** output:
        2022-08-29T10:52:23: Hello
    */
}
