using System;

namespace e
{
    class Program
    {
        // 未完成
        static void Main(string[] args)
        {
            var (n, k) = (Console.ReadLine(), int.Parse(Console.ReadLine()));
            int count = 0;
            for (int i = 1; i <= n.Length; i++) 
            {
                int number = i;
                int nonZeroCount = 0;
                for (;;) 
                {
                    if (number % 10 != 0) nonZeroCount++;
                    number = number / 10;

                    if (number == 0 || nonZeroCount > k) break;
                }
                if (nonZeroCount == k) count++;
            }
            Console.WriteLine(count);
        }
    }
}
