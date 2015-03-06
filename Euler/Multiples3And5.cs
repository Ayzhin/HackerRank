using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Euler
{
    class Multiples3And5
    {
        static void Main(string[] args)
        {
            long x = Convert.ToInt64(Console.ReadLine());

            if(x >= 1 && x <= 100000)
            {
                for (int i = 0; i < x; i++)
                {
                    long w = Convert.ToInt64(Console.ReadLine());

                    if(w >= 1 && w <= 1000000000)
                    {
                        long total = 0;

                        total = func(3, w) + func(5, w) - func(15, w);

                        Console.WriteLine(total);
                    }
                }
            }
        }

        static long func(long a, long b)
        {
            long c;

            b = b - 1;
            c = b / a;

            return (a * c * (c + 1)) / 2;
        }
    }
}
