using System;
using System.Linq;

// 分からなかった
namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var (n, k) = (inputs[0], inputs[1]);
            int tss = new int[n][n];

            for (int i = 0; i < n; i++) 
            {
                var ts = Console.ReadLine().Split().Select(int.Parse).ToArray();
                tss[i] = ts;
            }
            
            Console.WriteLine();
        }
    }
}