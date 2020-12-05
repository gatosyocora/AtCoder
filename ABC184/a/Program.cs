using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var (a, b) = (inputs[0], inputs[1]);
            var inputs2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var (c, d) = (inputs2[0], inputs2[1]);
            Console.WriteLine(a * d - b * c);
        }
    }
}