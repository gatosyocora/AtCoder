using System;

namespace d
{
    class Program
    {
        // 未完成
        static void Main(string[] args)
        {
            var s = int.Parse(Console.ReadLine());

            if (s <= 2) 
            {
                Console.WriteLine(0);
                return;
            }

            var counts = new int[s + 1];
            
            for (int n = 1; n <= s; n++) 
            {
                if (n <= 2)
                {
                    continue;
                }

                for (int i = 0; i < l; i++)
                {
                    if (s - n <= 2) break;
                }

                counts[n]++;
            }
        }
    }
}
