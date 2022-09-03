using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        class Vector3
        {
            float _x = 0;
            float _y = 0;
            float _z = 0;
            public Vector3(float x, float y, float z)
            {
                _x = x; _y = y; _z = z;
            }
            public void Deconstruct(out float x, out float y, out float z)
            {
                x = _x; y = _y; z = _z;
            }
        }

        static void Main(string[] args)
        {
            var point = new Vector3(1.0f, 2.0f, 3.0f); //x=1, y=2, z=3  
            if (point is Vector3(1.0f, var myY, _))
            {
                // Code here will be executed only if the point .X == 1, myY is a new variable  
                // that can be used in this scope.  
                Console.WriteLine("pattern matched");
            }
        }
    }
    /** output:
        pattern matched
    */
}
