using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int doubletCount = 0;
            for (int i = 0; i < n; i++) 
            {
                var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var (d1, d2) = (inputs[0], inputs[1]);

                if (d1 == d2) 
                {
                    doubletCount++;
                    if (doubletCount >= 3) 
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
                else 
                {
                    doubletCount = 0;
                }
            }
            Console.WriteLine("No");
        }
    }
}
