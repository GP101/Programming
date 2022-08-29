using System;
using static System.Math;

class Program
{
    public static Tuple<double, double> SolarAngleNew(double latitude, double declination, double hourAngle)
    {
        var tmp = Asin(latitude) * Sin(declination) + Cos(latitude) * Cos(declination) * Cos(hourAngle);
        return Tuple.Create(Asin(tmp), Acos(tmp));
    }
    public static void Main(string[] args)
    {
        for (var angle = 0.0; angle <= Math.PI * 2.0; angle += Math.PI / 8) { }
        //PI is const, not static, so requires Math.PI
    }
}