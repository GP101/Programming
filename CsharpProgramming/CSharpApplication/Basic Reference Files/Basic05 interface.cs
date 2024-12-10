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

    //public interface IMouseEvent
    //{
    //    void OnPointEnter();
    //    void OnPointExit();
    //}

    public class KDerived : IBase//, IMouseEvent
    {
        public void Start() { Console.WriteLine("KDerived::Start"); }
        public void Update() { Console.WriteLine("KDerived::Update"); }
        //public void OnPointEnter() { }
        //public void OnPointExit() { }
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
            Console.ReadKey();
            /*
                KDerived::Start
                KDerived::Update
                KDerived::Start
                KDerived::Update
            */
        }
    }
}
