using System;

namespace SumAndAvg
{
    class Program
    {
        static void SumAvg(int[] arr)
        {
            int sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }
            Console.WriteLine("sum : " + sum);
            Console.WriteLine("avg : " + sum / arr.Length);
        }
        static void Main(string[] args)
        {
            int[] abc = new int[5] { 1, 2, 3, 4, 5 };
            SumAvg(abc);
        }
    }
}