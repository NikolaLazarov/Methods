using System;
using static System.Console;

namespace Листинг_5._1
{
    class Program
    {
        static void show(string txt)
        {
            WriteLine(txt);
        }
        static int factorial(int n)
        {
            int s = 1;
            for (int k = 1; k <= n; k++)
            {
                s *= k;
            }
            return s;
        }
        static double power(double x, int n)
        {
            double s = 1;
            for (int k = 1; k <= n; k++)
            {
                s *= x;
            }
            return s;
        }
        static void Main(string[] args)
        {
            show("Започваме изчисленията:");
            int m = 5;
            double z = 3, num;
            show(m + " != " + factorial(m));
            num = power(z, m);

            show(z + " на степен " + m + ": " + num);

            WriteLine("Press nay key to close...");
            ReadKey(true);
        }
    }
}
