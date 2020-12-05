using System;
using System.Linq;

// 解けなかった
namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var (r1, c1) = (inputs[0], inputs[1]);
            var inputs2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var (r2, c2) = (inputs2[0], inputs2[1]);

            int count = 0;
            int rnow = r1, cnow = c1;

            if (r1 == r2 && c1 == c2) 
            {
                Console.WriteLine(0);
                return;
            }
            
            while (true) 
            {
                float minDist = float.MaxValue;
                int minC = 0, minR = 0;

                // 入力によっては途中でcがマイナスになることもある...
                for (int c = 1; c <= c2; c++) 
                {
                    if (minDist > CalcDistance(rnow + cnow - c, c, r2, c2)) 
                    {
                        minDist = CalcDistance(rnow + cnow - c, c, r2, c2);
                        minC = c;
                        minR = rnow + cnow - c;
                    }

                    if (minDist > CalcDistance(rnow - cnow + c, c, r2, c2)) 
                    {
                        minDist = CalcDistance(rnow - cnow + c, c, r2, c2);
                        minC = c;
                        minR = rnow - cnow + c;
                    }

                    for (int r = 1; r <= r2; r++)
                    {
                        if (Math.Abs(rnow - r) + Math.Abs(cnow - c) <= 3 &&
                            minDist > CalcDistance(r, c, r2, c2)) 
                        {
                            minDist = CalcDistance(r, c, r2, c2);
                            minC = c;
                            minR = r;
                        }
                    }
                }

                rnow = minR;
                cnow = minC;
                count++;

                if (rnow == r2 && cnow == c2) break;
            }
            
            Console.WriteLine(count);
        }

        static float CalcDistance(int a, int b, int c, int d) 
        {
            return (float)Math.Sqrt(Math.Pow(Math.Abs(a - c), 2) + Math.Pow(Math.Abs(b - d), 2));
        }
    }
}