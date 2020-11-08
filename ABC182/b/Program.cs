using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var gcds = new int[1000];

            for (int i = 0; i < n; i++) 
            {
                for (int k = 2; k <= inputs[i]; k++) 
                {                
                    if (inputs[i] % k == 0) gcds[k - 1]++;
                }
            }
            
            Console.WriteLine(Array.IndexOf(gcds, gcds.Max()) + 1);
        }
    }
}