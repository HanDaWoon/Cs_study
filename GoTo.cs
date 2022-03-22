using System;

namespace GoTo
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (i + j == 5) goto outer;
                    Console.Write("i=" + i + "j=" + j + " ");
                }
                Console.WriteLine();
            }
        outer:;
        }
    }
}