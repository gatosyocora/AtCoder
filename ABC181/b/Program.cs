using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++) 
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                sum += Sum((double)input[1]) - Sum((double)(input[0] - 1));
            }
            Console.WriteLine(sum);
        }

        static double Sum(double maxNumber) 
        {
            return (maxNumber * Math.Ceiling(maxNumber / 2)) + (maxNumber % 2 == 0 ? maxNumber / 2 : 0);
        }
    }
}
