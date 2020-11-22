using System;
using System.Linq;

// TLE
namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var (n, w) = (inputs[0], inputs[1]);

            var maxTime = 0;
            int[,] data = new int[n, 3];
            for (int i = 0; i < n; i++) 
            {
                var inputs2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                (data[i, 0], data[i, 1], data[i, 2]) = (inputs2[0], inputs2[1], inputs2[2]);
                if (maxTime < inputs2[1]) maxTime = inputs2[1];
            }

            int sum = 0;
            for (int t = 1; t <= maxTime; t++) 
            {
                sum = w;
                for (int i = 0; i < n; i++) 
                {
                    if (data[i, 0] < t && data[i, 1] >= t) 
                    {
                        sum -= data[i, 2];
                        if (sum < 0) 
                        {
                            Console.WriteLine("No");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("Yes");
        }
    }
}