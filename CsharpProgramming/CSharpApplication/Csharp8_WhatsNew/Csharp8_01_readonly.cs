using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        //public double Distance => Math.Sqrt(X * X + Y * Y); // before
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);

        //public override string ToString() => // before
        public readonly override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            Console.WriteLine(point.ToString());
        }
    }
    /** output:
        (0, 0) is 0 from the origin
    */
}
