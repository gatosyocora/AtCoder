using System;
using System.Linq;

namespace c
{
    class Program
    {
        // 未完成
        // 重複パターンがある(0xxxx9となったときに00xxx9となる場合があるが、x0xxx9のときも00xxx9となる場合があり、重複する)
        // 余事象を使うと良いっぽい
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            if (n <= 1) 
            {
                Console.WriteLine(0);
                return;
            }

            var mod = Math.Pow(10, 9) + 7;

            // Math.Pow(10, n-2)は無限大になるので適宜modする
            double s = 1;
            for (int i = 0; i < n - 2; i++)
            {
                s = s * 10 % mod;

            }

            Console.WriteLine(n * s % mod);
        }
    }
}
