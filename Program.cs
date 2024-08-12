using System;

namespace SUDUNGCAULENHLAP
{
    class HienThiSoNguyenToNhoHon100
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                int solanchiahet = 0;
                for (int j = 1; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        solanchiahet++;
                    }
                }
                if (solanchiahet == 1)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}