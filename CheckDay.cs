using System;

namespace CheckDay
{
    class Program
    {
        static void IfDay()
        {
            int day;
            Console.Write("Enter the day number 1 ~ 7 : ");
            day = (int)Console.Read() - '0';
            Console.WriteLine();
            if (day == 1) Console.WriteLine("Sunday");
            else if (day == 2) Console.WriteLine("Monday");
            else if (day == 3) Console.WriteLine("Tuesday");
            else if (day == 4) Console.WriteLine("Wednesday");
            else if (day == 5) Console.WriteLine("Thursday");
            else if (day == 6) Console.WriteLine("Friday");
            else if (day == 7) Console.WriteLine("Saturday");
            else Console.WriteLine("Illegal day");
        }
        static void SwitchDay()
        {
            Console.Write("Enter the day number 1 ~ 7 : ");
            int day = Console.Read() - '0';
            Console.WriteLine();
            switch (day)
            {
                case 1: Console.WriteLine("Sunday"); break;
                case 2: Console.WriteLine("Monday"); break;
                case 3: Console.WriteLine("Tuesday"); break;
                case 4: Console.WriteLine("Wednesday"); break;
                case 5: Console.WriteLine("Thursday"); break;
                case 6: Console.WriteLine("Friday"); break;
                case 7: Console.WriteLine("Saturday"); break;
                default: Console.WriteLine("Illegal day"); break;
            }
        }
        static void Main(string[] args)
        {
            IfDay();
            SwitchDay();
        }
    }
}