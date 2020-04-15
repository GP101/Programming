using System;

class NullCoalesce
{
    static void Main()
    {
        Nullable<int> i = null;
        if( i.HasValue == true )
            Console.WriteLine( i.Value );
        i = 9;
        if( i.HasValue == true )
            Console.WriteLine( "i=" + i.Value.ToString() );

        // nullable int type
        int? j = null;
        if( j != null )
            Console.WriteLine( j );
        j = 99;
        if( j != null )
            Console.WriteLine( "j=" + j.ToString() );

        int? x = null;

        // null coalesce operator
        // Set y to the value of x if x is NOT null; otherwise,
        // if x == null, set y to -1.
        int y = x ?? -1;
    }
}
