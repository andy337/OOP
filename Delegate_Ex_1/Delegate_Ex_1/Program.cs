using System;

namespace Delegate_Ex_1
{
    public delegate double Operation(double num);
    class Program
    {

        private static double Sqrt(double num) => Math.Sqrt(Math.Abs(num));

        private static double Myltiply(double num) => Math.Pow(num, 3);

        private static double Plus(double num) => num + 3.5;

        static void Main(string[] args)
        {
            Console.WriteLine("Вводьте рядки послiдовно один за одним.\n" +
                "Поки вони матимуть вигляд 0 x чи 1 x чи 2 x\n" +
                "(тобто, цифра вiд 0 до 2, а пiсля неї запис конкретного дiйсного числа),\n" +
                "програма обчислюватиме одну з трьох функцiй\n " +
                "\t 0 -- sqrt(abs(x))\n" +
                "\t 1 -- x^3 (?накше кажучи, x*x*x)\n" +
                "\t 2 -- x + 3,5");
            Operation[] op = new Operation[]
            {
                Sqrt, Myltiply, Plus
            };

            bool start = true;

            while (start)
            {
                try
                {
                    string str = Console.ReadLine();
                    string[] s = str.Split(' ');
                    Console.WriteLine(op[int.Parse(s[0])](double.Parse(s[1])));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    start = false;
                }
            }
        }
    }
}