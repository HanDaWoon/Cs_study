using System;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 3 5 7 9");
            for (int i = 1; i <= 10; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 1)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int num = 0;
            while (num++ < 10)
            {
                if (num % 2 == 0)
                    continue;
                Console.Write(num + " ");
            }
        }
    }
}