using System;
using static System.Console;

namespace Задача_1
{
    class Program
    {
        static void show(string txt)
        {
            WriteLine(txt);
        }
        static int factorial(int n)
        {
            int fn = 1;
            int l = n / 2;

            for (int i = 0; i < l; i++)
            {
                fn *= n;
                n -= 2;
            }
            return fn;
        }
        static void Main(string[] args)
        {
            Write("Enter a number: ");
            int p = Int32.Parse(ReadLine());
            show(p + "!! = " + factorial(p));


            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
