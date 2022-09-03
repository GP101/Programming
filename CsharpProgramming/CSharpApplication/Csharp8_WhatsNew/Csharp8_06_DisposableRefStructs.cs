using System.Collections.Generic;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static int WriteLinesToFile(IEnumerable<string> lines)
        {
            using var file = new System.IO.StreamWriter("WriteLines2.txt");
            int skippedLines = 0;
            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
                else
                {
                    skippedLines++;
                }
            }
            // Notice how skippedLines is in scope here.
            return skippedLines;
            // file.Dispose(); // file is disposed here
        }

        static void Main(string[] args)
        {
        }
        /** output:
        */
    }
}
