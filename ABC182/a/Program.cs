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

            Console.WriteLine((2 * a + 100) - b);
        }
    }
}