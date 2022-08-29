using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var dict = new Dictionary<string, int>
        {
            ["key1"] = 1,
            ["key2"] = 50
        };

        var dict2 = new Dictionary<string, int>();
        dict2["key1"] = 1;
        dict2["key2"] = 50;
    }
}
