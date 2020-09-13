using System;
using System.Linq;

namespace ABC154
{
    class Program
    {
        // 1からnまでの期待値は中央値と同じになる
        static float CalcMedianValue(int maxValue)
        {
            return maxValue % 2 == 1 ? 
                        (float)(maxValue - (maxValue / 2)) :
                        (float)(maxValue - (maxValue / 2) + 0.5);
        }

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var (n, k) = (inputs[0], inputs[1]);
            var maxValues = Console.ReadLine().Split(' ').Select(int.Parse);
            var expectedValues = maxValues.Select(CalcMedianValue).ToArray();

            double sum = Enumerable.Range(0, k).Sum(i => expectedValues[i]);
            var maxSumValue = sum;

            for (int i = 1; i <= n - k; i++) 
            {
                sum -= expectedValues[i - 1];
                sum += expectedValues[i + k - 1];
                if (maxSumValue < sum)
                {
                    maxSumValue = sum;
                }
            }

            Console.WriteLine($"{maxSumValue:F12}");
        }
    }
}
