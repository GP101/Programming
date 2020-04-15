using System;

class NullCoalesce
{
    static void Main()
    {
        Nullable<int> i = null;
        int j = null;
        if( i.HasValue == true )
            Console.WriteLine( i.Value );
        i = 9;
        if( i.HasValue == true )
            Console.WriteLine( "i=" + i.Value.ToString() );
    }
}
