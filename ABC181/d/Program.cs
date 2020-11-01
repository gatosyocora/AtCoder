using System;
using System.Linq;

// 作成途中で終わった
namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            // 最後の一桁が2,4,6,8のいずれかである必要がある
            if (!s.ToCharArray().Select<char, int>(int.Parse).Any(x => x % 2 == 0 && x != 9)) 
            {
                Console.WriteLine("No");
                return;
            }
            Console.WriteLine(int.Parse(s) % 8 == 0 ? "Yes" : "No");
        }
    }
}
