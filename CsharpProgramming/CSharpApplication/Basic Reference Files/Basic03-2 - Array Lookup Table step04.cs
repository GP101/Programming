using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    struct KeyValueInfo
    {
        public ConsoleKey key;
        public string dow;

        public KeyValueInfo( ConsoleKey key_, string dow_ )
        {
            key = key_;
            dow = dow_;
        }
    }

    static void Main( string[] args )
    {
        KeyValueInfo[] keyValue = new KeyValueInfo[2]
        {
            new KeyValueInfo(ConsoleKey.D1, "Sun"),
            new KeyValueInfo(ConsoleKey.D2, "Mon")
        };

        ConsoleKeyInfo keyInfo = Console.ReadKey( true );
        for( int i = 0; i < keyValue.Length; ++i )
        {
            if( keyInfo.Key == keyValue[i].key )
                Console.WriteLine( keyValue[i].dow );
        }
    }
}
