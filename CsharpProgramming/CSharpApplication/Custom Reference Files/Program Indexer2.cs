using System;
using System.Text;

namespace CsharpConsole
{
    public class KTest
    {
        string[] _name = new string[] { "Hello", "Unity", "Programming" };
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index <= 2)
                    return _name[index];
                return _title;
            }
            set
            {
                if (index >= 0 && index <= 2)
                {
                    _name[index] = value;
                    return;
                }
                _title = value;
            }
        }
        string _title = "Developer";
    }

    class Console
    {
        static void Main()
        {
            KTest e = new KTest();
            e[1] = "World";

            for (int i = 0; i < 4; ++i)
            {
                System.Console.WriteLine($"e[{i}]={e[i]}");
            }
            /** output:
                Hello World Programming */
        }
    }
}
