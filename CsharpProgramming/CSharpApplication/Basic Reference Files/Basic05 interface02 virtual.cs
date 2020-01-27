using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public interface IBase
    {
        // interface members
        void Start();
        void Update();
    }

    public class KDerived : IBase
    {
        public virtual void Start() { Console.WriteLine("KDerived::Start"); }
        public virtual void Update() { Console.WriteLine("KDerived::Update"); }
    }

    public class KFinal : KDerived
    {
        public override void Start() { Console.WriteLine("KFinal::Start"); }
        public override void Update() { Console.WriteLine("KFinal::Update"); }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            KDerived d = new KDerived();
            d.Start();
            d.Update();
            IBase b = new KDerived();
            b.Start();
            b.Update();
            IBase c = new KFinal();
            c.Start();
            c.Update();
            Console.ReadKey();
            /*
                KDerived::Start
                KDerived::Update
                KDerived::Start
                KDerived::Update
                KFinal::Start
                KFinal::Update            
            */
        }
    }
}
