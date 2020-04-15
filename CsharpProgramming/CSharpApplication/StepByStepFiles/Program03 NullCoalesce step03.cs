using System;

class NullCoalesce
{
    static int? GetNullableInt()
    {
        return null;
    }

    static string GetStringValue()
    {
        return null;
    }

    static void Main()
    {
        // Assign i to return value of the method if the method's result
        // is NOT null; otherwise, if the result is null, set i to the
        // default value of int.
        int k = GetNullableInt() ?? default( int );

        string s = GetStringValue();
        // Display the value of s if s is NOT null; otherwise, 
        // display the string "Unspecified".
        Console.WriteLine( s ?? "Unspecified" );
    }
}
