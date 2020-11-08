using System;
using System.Linq;

namespace d
{
    // 例は正しく解けたが、TLEになる
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var inputs = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long sum = 0;
            long max = 0;
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j <= i; j++) 
                {
                    sum += inputs[j];
                    if (sum > max) max = sum;
                }
            }

            Console.WriteLine(max);
        }
    }
}