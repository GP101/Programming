﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpApplication
{
    public abstract class KBase
    {
        public abstract void Start();
        public abstract void Update();
    }

    public class KDerived : KBase
    {
        public override void Start() { Console.WriteLine("KDerived::Start"); }
        public override void Update() { Console.WriteLine("KDerived::Update"); }
    }

    public class KFinal : KDerived
    {
        public override void Start() { Console.WriteLine("KFinal::Start"); }
        public override void Update() { Console.WriteLine("KFinal::Update"); }
    }

    public class KWrapper<T> where T : KBase, new()
    {
        private T _target;
        public KWrapper()
        {
            _target = new T();
        }
        public KWrapper(T t)
        {
            _target = t;
        }
        public void DoUpdate()
        {
            _target.Update();
        }
    }

    public class KTest
    {
        public void Update() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KWrapper<KDerived> p;
            p = new KWrapper<KDerived>(new KDerived());
            p.DoUpdate();
            KWrapper<KFinal> p2;
            p2 = new KWrapper<KFinal>();
            p2.DoUpdate();
        }
        /** output:
            KDerived::Update
            KFinal::Update
        */
    }
}
