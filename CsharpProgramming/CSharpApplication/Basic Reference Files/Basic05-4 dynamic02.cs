using System;

class Program
{
    public class KBase
    {
        // interface members
        public void Start() { Console.WriteLine( "KBase::Start" ); }
        public virtual void Update() { Console.WriteLine( "KBase::Update" ); }
    }

    public class KDerived : KBase
    {
        public void Start() { Console.WriteLine( "KDerived::Start" ); }
        public override void Update() { Console.WriteLine( "KDerived::Update" ); }
    }

    static void Main()
    {
        object o0 = new KDerived();
        dynamic o1 = new KDerived();
        KBase o2 = new KDerived();

        //o0.Start(); // (1) error at compile time
        o1.Start(); // (2)
        o2.Start();

        //o0.Update(); // (1) error at compile time
        o1.Update(); // (2)
        o2.Update();
        //o1.UndefinedFunction(); // (3) runtime exception
        /*  output:
            KDerived::Start
            KBase::Start
            KDerived::Update
            KDerived::Update
        */
    }
}