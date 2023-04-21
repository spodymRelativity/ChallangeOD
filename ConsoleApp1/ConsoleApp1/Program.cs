using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        //static async Task Main(string[] args)
        static void Main(string[] args)
        {

            string path = @"c:\work\dev\tmp\test\test3.txt";
            Program.Generate(path);

            
            Console.ReadLine();
        }

        
        public static void Generate(string path )
        {
            var seed = 3;
            var random = new Random(seed);
            var lowerBound = 1000;
            var upperBound = 1000000;
            File.WriteAllText(path, "");
            List<string> res = new List<string>();
            int[] arr = { 1082,2069,3076,4065,5084,6073,7086,8073,9084,10089, 10132, 10233, 10333, 10433 };

            File.AppendAllLines(path, arr.Select(a=>a.ToString()));
            for (int n = 0; n < 130000000; ++n)
            {
                var rNum = random.Next(lowerBound, upperBound);
                res.Add(rNum.ToString());
                if (n % 100000 == 0)
                {
                    File.AppendAllLines(path, res);
                    File.AppendAllLines(path, arr.Select(a => a.ToString()));
                    File.AppendAllLines(path, res);
                    File.AppendAllLines(path, arr.Select(a => a.ToString()));
                    res = new List<string>();
                }
            }
        }
    }
}
