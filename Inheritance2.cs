using System;

namespace Inheritance2
{
    // 베이스 클래스
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    // 파생클래스
    public class Dog : Animal
    {
        public void HowOld()
        {
            // 베이스 클래스의 Age 속성 사용
            Console.WriteLine("나이: {0}", this.Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog badok = new Dog();
            badok.Age = 3;
            badok.HowOld();
        }
    }
}

