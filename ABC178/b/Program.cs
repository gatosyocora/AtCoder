using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var (a, b, c, d) = (inputs[0], inputs[1], inputs[2], inputs[3]);

            long max = a * c;
            if (max < a * d) max = a * d;
            if (max < b * c) max = b * c;
            if (max < b * d) max = b * d;
            
            Console.WriteLine(max);
        }
    }
}
