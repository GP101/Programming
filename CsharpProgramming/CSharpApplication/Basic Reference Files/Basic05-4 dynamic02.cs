using System;

class Program
{
    public class KBase
    {
        // interface members
        public void Start() { Console.WriteLine( "KBase::Start" ); }
        public void Update() { Console.WriteLine( "KBase::Update" ); }
    }

    public class KDerived : KBase
    {
        public void Start() { Console.WriteLine( "KDerived::Start" ); }
        public void Update() { base.Update(); Console.WriteLine( "KDerived::Update" ); }
    }

    static void Main()
    {
        object o0 = new KDerived();
        dynamic o1 = new KDerived();

        //o0.Start(); // (1) error at compile time
        o1.Start(); // (2)

        //o0.Update(); // (1) error at compile time
        o1.Update(); // (2)
        o1.UndefinedFunction(); // (3) runtime exception
    }
}