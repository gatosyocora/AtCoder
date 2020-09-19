using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input.Last() == 's')  input += "es";
            else input += 's';

            Console.WriteLine(input);
        }
    }
}
