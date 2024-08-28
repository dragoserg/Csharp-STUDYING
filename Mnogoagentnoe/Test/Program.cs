using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            dict["1"] = 1;
            dict["2"] = 1;
            dict["3"] = 1;
            dict["4"] = 1;

            foreach (var obj in dict)
            {
                Console.WriteLine(obj.Value);
            }

            dict["1"] = 3;
            Console.WriteLine(dict["1"]);
        }
    }
}
