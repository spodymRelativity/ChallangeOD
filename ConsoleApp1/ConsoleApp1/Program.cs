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
            //Program.Generate(path);

            int n = 0;

            Console.WriteLine("START");
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            //var a = File.ReadAllLines(path);
            //var a = File.ReadLines(path);
            //foreach(var line in a)
            //{
            //    ;
            //}

            var lowerBound = 1000000;
            var upperBound = 1000000;
            HashSet<string> set = new HashSet<string>();
            int count = 0;

            using (FileStream fs = File.OpenRead(path))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    Dictionary<int, bool> res = new Dictionary<int, bool>();
                    var arr = new bool[upperBound];
                    int buffSize = 1024;
                    char[] buffer = new char[buffSize];
                    string line;
                    int i = 0;

                    //while((i=sr.Read())>0)
                    //{

                    //}

                    while ((line = sr.ReadLine()) != null)
                    {
                        //var a = new String(buffer).Split("\r\n");
                        if (!set.Remove(line))
                        {
                            set.Add(line);
                        }
                        //++n;
                        //int nr = int.Parse(line);
                        //arr[nr] = !arr[nr];
                        //if (!res.ContainsKey(nr))
                        //{
                        //    res.Add(nr, true);
                        //}
                        //else
                        //{
                        //    res[nr] = !res[nr];
                        //}
                    }
                    count = arr.Count(a => a);
                    Console.WriteLine("CHECKSUM:" );
                    Console.WriteLine("");
                    Console.WriteLine("");

                    for (int index=0; index < upperBound; ++index)
                    {
                        if(arr[index])
                        {
                            Console.Write((char)(index % 100));
                        }
                    }

                    Console.WriteLine("");
                    Console.WriteLine("");

                }
            }
            
            stopwatch.Stop();

            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.Elapsed.ToString());

            Console.WriteLine("STOP " + count);
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
