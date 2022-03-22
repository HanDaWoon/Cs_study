using System;

class Operator
{
    static void Main(string[] args)
    {
        int a = 8;
        int b = 8;
        Console.WriteLine(a >> 1);
        Console.WriteLine(b << 1);
        // Console.WriteLine(a <<< 1); <<<연산자 없음
    }
}