using System;

namespace DelegateTest
{
    // 대리자를 만들어준다.
    delegate void Del();    // 매개변수가 없고 반환형이 void형인 메서드만 참조 시킬 수 있다.
    class DelTest
    {
        public void Test()
        {
            Del myDel;  // myDel이라는 대리자 객체 생성
            myDel = Print;  // Print라는 메서드를 참조해준다.
            myDel();    // 대리자를 이용한 메서드 호출
        }
        public void Print()
        {
            Console.WriteLine("대리자를 통한 메서드 호출입니다.");
        }
        public static void Main(string[] args)
        {
            DelTest run = new DelTest();
            run.Test();
        }
    }
}