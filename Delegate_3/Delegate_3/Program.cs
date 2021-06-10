using System;

namespace Delegate_3
{
    public delegate void Operation(int[] arr);

    class Program
    {
        static void FindNums_7(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 7 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }

        static void FindNums_3(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 2, 5, 8, 21, 45, 9 };
            Operation[] operation = new Operation[2]
            {
                FindNums_3, FindNums_7
            };
            Console.WriteLine("Choose option:\n" +
                "1. Divide by 3\n" +
                "2. Divide by 7");
            int op = int.Parse(Console.ReadLine());
            operation[op - 1](arr);
            Console.ReadLine();
        }
    }
}
