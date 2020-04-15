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
    }

    static void Main( string[] args )
    {
        KeyValueInfo[] keyValue = new KeyValueInfo[2] { new KeyValueInfo(), new KeyValueInfo() };
        keyValue[0].key = ConsoleKey.D1;
        keyValue[0].dow = "Sun";
        keyValue[1].key = ConsoleKey.D2;
        keyValue[1].dow = "Mon";

        KeyValueInfo[] keyValue2 = new KeyValueInfo[2] 
        {
            new KeyValueInfo(){ key=ConsoleKey.D1, dow="Sun"},
            new KeyValueInfo(){ key=ConsoleKey.D2, dow="Mon"}
        };
    }
}
