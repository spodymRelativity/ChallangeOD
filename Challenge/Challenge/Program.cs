using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\work\dev\tmp\test\test3.txt";
            IEnumerable<int> result;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            using (FileStream fs = File.OpenRead(path))
            {
                OddNumberSelector counter = new OddNumberSelector();
                result = counter.Execute(fs);
            }

            stopwatch.Stop();
            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.Elapsed.ToString());

            Console.WriteLine("CHECKSUM:");
            Console.WriteLine("");
            Console.WriteLine("");

            foreach (var item in result)
            {
                Console.Write((char)(item % 100));
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
