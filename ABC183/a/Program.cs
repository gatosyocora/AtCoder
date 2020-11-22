using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            
            Console.WriteLine(x < 0? 0 : x);
        }
    }
}