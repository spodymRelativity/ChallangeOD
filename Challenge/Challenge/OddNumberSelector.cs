using System.Collections.Generic;
using System.IO;

namespace Challenge
{
    internal class OddNumberSelector
    {
        /*
            The stream contains integers in the <0, 1 000 000> range. Return the ones that occur an odd number of times.

            Attention
                The amount of data exceeds 1GB

            Limitations:
                - memory consumption < 200 MB
                - execution time < 1 min
        */

        internal IEnumerable<int> Execute(Stream fs)
        {
            throw new System.NotImplementedException();

            using (StreamReader sr = new StreamReader(fs))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {

                }
            }
        }
    }
}