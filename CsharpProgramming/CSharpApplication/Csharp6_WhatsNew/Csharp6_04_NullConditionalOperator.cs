using System;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    public event EventHandler HandoffOccurred = null;

    void Test()
    {
        string sender;
        EventArgs e = new EventArgs();
        HandoffOccurred?.Invoke(this, e);
    }

    static void Main()
    {
        var ss = new string[] { "Foo", null };
        var length0 = ss[0]?.Length; // 3
        var length1 = ss[1]?.Length; // null
        var lengths = ss.Select(s => s?.Length ?? 0); //[3, 0]

        Program p = new Program();
        p.Test();
    }
}