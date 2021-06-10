using System;

namespace Delegate_4
{
    class Program
    {
        private static double Factorial(double num)
        {
            double res = 1;
            for (double i = num; i > 1; i--)
            {
                res *= i;
            }
            return res;
        }
        public static double Calculate(Func<int, double> nthTerm, double eps = 1e-7)
        {
            double res = 0;
            int n = 0;
            double currentEps;
            do
            {
                double newRes = res + nthTerm(n);
                n++;
                currentEps = res - newRes;
                res = newRes;
            } while (Math.Abs(currentEps) > eps);
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1) 1 + 1/2 + 1/4 + 1/8 + 1/16 + ...\n" +
            "2) 1 + 1/2! + 1/3! + 1/4! + 1/5! + ...\n" +
            "3) 1 + 1/2 - 1/4 + 1/8 - 1/16 + ...\n");
            Console.WriteLine("Результат першої формули:");
            Console.WriteLine(Calculate(num => 1 / Math.Pow(2, num)));
            Console.WriteLine("Результат другої формули:");
            Console.WriteLine(Calculate(num => 1 / Factorial(num)));
            Console.WriteLine("Результат третьої формули:");
            Console.WriteLine(Calculate(num => Math.Pow(-1, num) / Math.Pow(2, num + 1), 0.01));
            Console.ReadKey();
        }
    }
}
