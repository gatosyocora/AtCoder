using System;
using System.Linq;
using System.Collections.Generic;

namespace d
{
    // 解けなかった
    class Program
    {
        static void Main(string[] args)
        {
            var inputs1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var (n, k) = (inputs1[0], inputs1[1]);
            
            var s = new List<int>();
            for (int i = 0; i < k; i++) 
            {
                var inputs2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                s.Add(inputs2[0]);
                s.Add(inputs2[1]);
            }

            // n - 1以下の数字しか使わない
            s = s.Distinct().Where(d => d < n).OrderBy(d => d).ToList();

            // 組み合わせをするんだろうけど無理
            var count = Hoge(0, n, s, s.Count()-1);
            Console.Write(count);
        }

        private static int Hoge(int sum, int n, List<int> s, int index) 
        {
            // 最後まで見たけどパターンではなかった
            if (index < 0) return 0;

            // パターンが見つかった
            if (sum + s[index] == n - 1) 
            {
                return 1;
            }
            // 加算するとオーバーする
            else if (sum + s[index] > n - 1) 
            {
                // 加算せずに次の要素で調べる
                return Hoge(sum, n, s, index-1);
            }
            // 加算してもまだ足りる
            else
            {
                // 加算して次の要素で調べる
                return Hoge(sum + s[index], n, s, index-1);
            }
        }
    }
}
