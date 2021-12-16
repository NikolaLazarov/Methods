using System;
using static System.Console;

namespace Листинг_5._8
{
    class Program
    {
        static int factorial(int n)
        {
            if (n == 1) return 1;
            else return n * factorial(n - 1);
        }
        static int fibs(int n)
        {
            if (n == 1 || n == 2) return 1;
            else return fibs(n - 1) + fibs(n - 2);
        }
        static int sum(int n)
        {
            if (n == 0) return 0;
            else return n + sum(n - 1);
        }
        static void show(int[] a, int k)
        {

            Console.Write(a[k] + " ");

            if (k == a.Length - 1)
            {
                Console.WriteLine();
            }

            else
            {

                show(a, k + 1);
            }
        }
        static void show(int[] a)
        {
            show(a, 0);
        }
        static void Main(string[] args)
        {
            WriteLine("Факториел на число : ");
            for (int k = 1; k <= 10; k++)
            {
                WriteLine(k + "!=" + factorial(k));
            }

            WriteLine("Числата на Фибоначи : ");
            for (int k = 1; k <= 10; k++)
            {
                Write(fibs(k) + " ");
            }
            WriteLine();

            Write("Сумата на числата от 1 до 100 : ");
            WriteLine(sum(100));

            int[] A = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
            WriteLine("Числов масив : ");
            show(A);

            WriteLine("Елементите, започвайки от третия : ");
            show(A, 2);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
