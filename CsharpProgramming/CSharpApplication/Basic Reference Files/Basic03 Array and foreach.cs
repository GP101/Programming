using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int[] marks = new int[5] { 99, 98, 92, 97, 95 };
        int[] marks2 = { 99, 98, 92, 97, 95 };
        int[,] a = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        for (int i = 0; i < marks.Length; ++i)
        {
            Console.Write("marks[{0}]={1}\r\n", i, marks[i]);
        }
        foreach (int j in marks2)
            Console.Write("j={0}\r\n", j);
        for (int row = 0; row < a.GetLength(0); ++row)
        { // (3)
            for (int col = 0; col < a.GetLength(1); ++col)
            {
                Console.Write(String.Format("a[{0},{1}]={2},"
                    , row, col, a[row, col]));
                //Console.Write($"a[{row},{col}]={a[row][col]},"); // doesn't work
            }
        }
    }
}
/*  output:
    marks[0]=99
    marks[1]=98
    marks[2]=92
    marks[3]=97
    marks[4]=95
    j=99
    j=98
    j=92
    j=97
    j=95
    a[0,0]=1,a[0,1]=2,a[0,2]=3,a[1,0]=4,a[1,1]=5,a[1,2]=6,
*/
