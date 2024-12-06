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

        public KeyValueInfo(ConsoleKey key_, string dow_)
        {
            key = key_;
            dow = dow_;
        }
    }

    static void Main(string[] args)
    {
        int baseValue = 0;
        int[][] a = new int[2][];
        for (int row = 0; row < a.Length; row++) {
            a[row] = new int[3] { baseValue + 1, baseValue + 2, baseValue + 3 };
            baseValue += 3;
        }
        for (int row = 0; row < a.Length; row++) {
            for (int col = 0; col < a[row].Length; col++) {
                Console.Write("{0},", a[row][col]);
            }
            Console.WriteLine();
        }

        // step1. create 2D jagged array(array of array) itself
        KeyValueInfo[][] keyValueArray = new KeyValueInfo[2][];
        for (int row = 0; row < keyValueArray.Length; row++) {
            keyValueArray[row] = new KeyValueInfo[3];
        }
        // step2. create an instance for array entry
        for (int row = 0; row < keyValueArray.Length; row++) {
            for (int col = 0; col < keyValueArray[row].Length; col++) {
                keyValueArray[row][col] = new KeyValueInfo(ConsoleKey.C, "dummy");
            }
        }
    }
}
