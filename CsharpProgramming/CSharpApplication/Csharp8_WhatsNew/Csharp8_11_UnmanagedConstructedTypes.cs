using static System.Console;

namespace ConsoleApp1
{
    public struct Foo<T>
    {
        public T Var1;
        public T Var2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Pointer   
            var foo = new Foo<int> { Var1 = 0, Var2 = 0 };
            unsafe
            {
                var bar = &foo; // C# 8   
            }

            // Block of memory   
            Span<Foo<int>> bars = stackalloc[]
            {
                new Foo<int> { Var1 = 0, Var2 = 0 },
                new Foo<int> { Var1 = 0, Var2 = 0 }
            };
        }
        /** output:
        */
    }
}
/**
    Unmanaged constructed types
 
    In C# 7.3 and earlier, a constructed type (a type that includes at least one type of argument) can't be an unmanaged type. Starting with C# 8.0, a constructed value type is unmanaged if it contains fields of unmanaged types only. 

    public struct Foo<T>   
    {   
      public T Var1;   
      public T Var2;   
    }   

    Bar<int> type is an unmanaged type in C# 8.0. Like for any unmanaged type, you can create a pointer to a variable of this type or allocate a block of memory on the stack for instances of this type:

    // Pointer   
    var foo = new Foo <int> { Var1 = 0, Var2 = 0 },   
    var bar = &foo; // C# 8   
  
    // Block of memory   
    Span< Foo<int>> bars = stackalloc[]   
    {   
      new Foo <int> { Var1 = 0, Var2 = 0 },   
      new Foo <int> { Var1 = 0, Var2 = 0 }   
    };   

    Notes
    -  This feature is a performance enhancement.
    -  Constructed value types are now unmanaged if it only contains fields of unmanaged types.
    -  This feature means that you can do things like allocate instances on the stack. 
*/