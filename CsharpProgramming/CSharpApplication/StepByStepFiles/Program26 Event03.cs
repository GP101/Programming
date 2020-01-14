using System;
using System.Text;
using System.Reflection;

class Program1
{
    public class HelloEventArgs : EventArgs
    {
        public int Time { get; set; }
    }
    public delegate void HelloDelegate(object sender, HelloEventArgs args);

    class Sample
    {
        public event HelloDelegate hello;

        public void DoAction()
        {
            hello(this, new HelloEventArgs { Time = 2 });
        }
    }

    class Subscriber
    {
        private Sample _sample;
        public Subscriber(Sample s)
        {
            _sample = s;
            _sample.hello += Handler;
        }
        public void Handler(object sender, HelloEventArgs args)
        {
            Console.WriteLine("{0} received event {1} from {2}."
                , this.ToString(), args.Time, sender.ToString());
        }
    }

    static void Main(string[] args)
    {
        Sample s = new Sample();
        Subscriber t = new Subscriber(s);
        s.DoAction();
    }
    /** output:
        Program1+Subscriber received event 2 from Program1+Sample.
    */
}
