using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
            A = x / 2;
            do
            {
                A = A * 1 / ((2 * N + 2) * (2 * N + 1));
                S = S + A;
                N += 1;
            }
            while (A >= E);
            Console.WriteLine($"Результат: {S:f2} Число итераций: {N}\n");
        }
    }
}
