using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var (sx, sy) = (inputs[0], inputs[1]);
            var (gx, gy) = (inputs[2], inputs[3]);

            var dx = gx - sx;
            var dy = gy + sy;
            var a = dy / dx;
            var px = sx + sy / a;
            
            Console.WriteLine(px);
        }
    }
}