using System;
namespace Inheritance
{
    class Robot
    {
        public String name;
    }
    class HumanoidRobot : Robot
    {
        public HumanoidRobot(String name)
        {
            base.name = name;
        }
        public void printName()
        {
            Console.WriteLine(name);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            HumanoidRobot hr = new HumanoidRobot("abc");
            hr.printName();
        }
    }
}