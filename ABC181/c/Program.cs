using System;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var xArray = new int[n];
            var yArray = new int[n];
            for (int i = 0; i < n; i++) 
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                xArray[i] = input[0];
                yArray[i] = input[1];
            }

            for (int i = 0; i < n - 2; i++) 
            {
                for (int j = i + 1; j < n - 1; j++) 
                {
                    var dx = xArray[j] - xArray[i];
                    var dy = yArray[j] - yArray[i];
                    var t = dx != 0 ? dy / (float)dx : float.MaxValue;

                    for (int k = j + 1; k < n; k++) 
                    {
                        var dx2 = xArray[k] - xArray[i];
                        var dy2 = yArray[k] - yArray[i];
                        var t2 = dx2 != 0 ? dy2 / (float)dx2 : float.MaxValue;

                        if (t == t2) 
                        {
                            Console.WriteLine("Yes");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("No");
        }
    }
}
