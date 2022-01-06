using System;
using static System.Console;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5;
            sumofNums(A);

            WriteLine("Press nay key to exit...");
            ReadKey(true);
        }
        static void sumofNums(int n)
        {
            int k = 0;
            for (int i = 1; i <= n; i++)
            {
                k += i * i;
            }
            WriteLine(k);
        }
    }
}
