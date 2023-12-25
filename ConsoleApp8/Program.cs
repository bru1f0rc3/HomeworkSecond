using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            const double E = 0.001;
            double A, S;
            int N;
            Console.Write("Введите X:");
            double x = double.Parse(Console.ReadLine());
            S = 0;
            N = 0;
            A = x;
            do
            {
                S = S + A;
                N = N + 1;
                A = A * x * x * (2 * N - 1) / (2 * N * (2 * N + 1));
            }
            while (A >= E);
            Console.WriteLine($"Результат: {S:f2} Число итераций: {N}\n");
        }
    }
}
