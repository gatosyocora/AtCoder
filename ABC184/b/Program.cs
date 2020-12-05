using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var (n, x) = (inputs[0], inputs[1]);
            var s = Console.ReadLine();

            for (int i = 0; i < n; i++) 
            {
                if (s[i] == 'o') x++;
                else if (x > 0) x--;
            }

            Console.WriteLine(x);
        }
    }
}