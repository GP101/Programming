using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            var lastName = "Seo";
            Console.WriteLine("{0} {1}", firstName, lastName);
            //System.Type t = lastName.GetType();
            //Console.WriteLine("{0}", t.Name);
            //lastName = 1; // generate compile time error
            //dynamic lastName = "Seo";
            //lastName = 1; // ok for dynamic type
            //Console.WriteLine("{0}", lastName.GetType().Name);
            //// Jonh Seo
            //// String
        }
    }
}
