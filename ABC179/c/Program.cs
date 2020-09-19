using System;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int count = 0;

            // a*b+c=nを満たすa,b,cはa,bが決まれば必ず1つに定まる(a*b<nの場合)

            for (int a = 1; a < n; a++) 
            {
                for (int b = 1; b < n; b++) 
                {
                    if (a * b < n) count++;
                    else if(a * b >= n) break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
