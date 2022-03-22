using System;

namespace ConsoleApplication1
{
    class Array
    {

        static void OneDimensionalArray()
        {
            // 1차원 배열
            // 자료형[] 배열명 = new 자료형[크기];
            int[] arr = new int[5] { 1, 2, 3, 4, 5 }; //== int[] arr = { 1, 2, 3, 4, 5 };
                                                      // or
            int[] arr2 = new int[3];
            arr2[0] = 10;
            arr2[1] = 20;
            arr2[2] = 30;
            // foreach (var i in arr) { Console.WriteLine(i); }
            for (int i = 0; i < arr.Length; i++) { Console.WriteLine("arr[" + i + "]=" + arr[i]); }
            for (int i = 0; i < arr2.Length; i++) { Console.WriteLine("arr2[" + i + "]=" + arr2[i]); }
        }
        static void SystemArray()
        {
            // System.Array

            int[] reading = new int[] { 4, 9, 1, 0, 21, 12 };

            Console.WriteLine("속성: Rank={0}, Length={1}", reading.Rank, reading.Length);
            // reading의 차원 수와 길이를 반환함

            Console.Write("Clear 메소드: ");
            System.Array.Clear(reading, 0, 5); // 배열 요소를 0부터 시작하여 5개의 요소를 초기화 시킴
                                               // Array.Clear(요소를 지울 배열, 시작 인덱스, 지울 요소수);
            System.Array.ForEach<int>(reading, new System.Action<int>(ShowValue));
            // 해당 배열의 각 요소를 가지고 동작(ShowValue)를 수행함
            // Array.ForEach<데이터타입>(동작을 수행할 배열, new Action<데이터타입>(액션);
            Console.WriteLine();

            Console.Write("Resize 메소드: ");
            System.Array.Resize(ref reading, reading.Length + 3);
            // reading 배열의 길이를 3만큼 늘림, Array.Resize(배열의 주소값, 새 배열의 크기);
            System.Array.ForEach<int>(reading, new System.Action<int>(ShowValue));
            Console.WriteLine();

            Console.WriteLine("indexOf 메소드: {0}", System.Array.IndexOf(reading, 12));
            // 배열에서 12란 값을 가지고 있는 요소의 인덱스를 반환함
            // Array.IndexOf(배열, 찾고자 하는 값);
        }

        static void ShowValue(int value) // 동작, value를 받아 그 value를 출력시킴
        {
            Console.Write("{0} ", value);
        }

        static void MultidimensionalArray()
        {
            int[,] reading = new int[3, 6] { { 4, 9, 1, 0, 21, 12 }, { 1, 4, 6, 0, 9, 5 }, { 4, 4, 2, 4, 0, 0 } };

            for (int i = 0; i < reading.GetLength(0); i++)
                for (int j = 0; j < reading.GetLength(1); j++)
                    Console.WriteLine("reading[" + i + ", " + j + "] = {0}", reading[i, j]);
        }

        static void Main(string[] args)
        {
            // OneDimensionalArray();
            // SystemArray();
            MultidimensionalArray();
        }
    }
}
