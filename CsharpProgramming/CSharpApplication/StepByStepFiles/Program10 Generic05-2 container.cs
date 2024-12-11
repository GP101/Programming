using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void PrintAssemblyInfo()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine("Type: " + type.Name + ", Base Type: " + type.BaseType);
                var props = type.GetProperties();
                foreach (var prop in props)
                {
                    Console.WriteLine("\tProp: " + prop.Name);
                }
                var fields = type.GetFields();
                foreach (var field in fields)
                {
                    Console.WriteLine("\tField: " + field.Name);
                }
                var methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("\tMethod: " + method.Name);
                }
            }
        }
        public class KPoint
        {
            private int _x, _y;

            public KPoint(int x, int y)
            {
                _x = x;
                _y = y;
            }

            public class EqualityComparer : IEqualityComparer<KPoint>
            {
                public bool Equals(KPoint? lhs, KPoint? rhs)
                {
                    return lhs?._x == rhs?._x && lhs?._y == rhs?._y;
                }

                public int GetHashCode(KPoint p)
                {
                    return p._x ^ p._y;
                }
            }

            public int GetX()
            {
                return _x;
            }
        }

        static void Main(string[] args)
        {
            //Dictionary<KPoint, string> parkingInfo = new Dictionary<KPoint, string>();
            Dictionary<KPoint, string> parkingInfo = new Dictionary<KPoint, string>(new KPoint.EqualityComparer());
            parkingInfo.Add(new KPoint(1, 1), "first point");
            bool isKey = parkingInfo.ContainsKey(new KPoint(1, 1));
            parkingInfo.TryAdd(new KPoint(1, 1), "second point");
            foreach (KeyValuePair<KPoint, string> pair in parkingInfo)
            {
                Console.WriteLine("{0} {1}", pair.Key.GetX(), pair.Value);
            }

            //PrintAssemblyInfo();
        }
    }
    /*
        1 first point
        Type: Program, Base Type: System.Object
                Method: Equals
                Method: GetHashCode
                Method: GetType
                Method: ToString
        Type: KPoint, Base Type: System.Object
                Method: GetX
                Method: Equals
                Method: GetHashCode
                Method: GetType
                Method: ToString
        Type: EqualityComparer, Base Type: System.Object
                Method: Equals
                Method: GetHashCode
                Method: Equals
                Method: GetHashCode
                Method: GetType
                Method: ToString
    */
}
