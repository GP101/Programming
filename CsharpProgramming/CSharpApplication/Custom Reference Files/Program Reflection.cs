﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

class Program1
{
    static void Main( string[] args )
    {
        var assembly = Assembly.GetExecutingAssembly();
        var types = assembly.GetTypes();
        foreach( var type in types )
        {
            Console.WriteLine( "Type: " + type.Name + ", Base Type: " + type.BaseType );
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
        Sample sample = new Sample { Name = "Hello", age = 49 };
        var sampleType = typeof(Sample);
        var nameProperty = sampleType.GetProperty("Name");
        Console.WriteLine("Property: " + nameProperty.GetValue(sample));

        var updateMethod = sampleType.GetMethod("Update");
        object[] paramArray = new object[1] { 1.2f };
        updateMethod.Invoke(sample, paramArray);
    }
    public class Sample
    {
        public string Name { get; set; }
        public int age;
        public void Update( float elapsedTime )
        {
            Console.WriteLine( "Sample.Update(), " + elapsedTime );
        }
    }
}
/** output
 * Type: Program1, Base Type: System.Object
        Method: ToString
        Method: Equals
        Method: GetHashCode
        Method: GetType
Type: Sample, Base Type: System.Object
        Prop: Name
        Field: age
        Method: get_Name
        Method: set_Name
        Method: Update
        Method: ToString
        Method: Equals
        Method: GetHashCode
        Method: GetType
Property: Hello
Sample.Update(), 1.2
계속하려면 아무 키나 누르십시오 . . .
*/