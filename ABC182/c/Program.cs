using System;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();

            var k = n.Length;
            for (int d = 0; d < k; d++) 
            {
                for (int i = 0; i < k; i++) 
                {
                    var n2 = n.Remove(i, d);
                    if (ulong.Parse(n2) % 3 == 0) 
                    {
                        Console.WriteLine(d);
                        return;
                    }
                }
            }
            Console.WriteLine(-1);
        }
    }
}