using System;
using static System.Console;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Meth(1, 8);
            Meth('A', 'H');

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
        static void Meth(int a, int b)
        {
            int[] arrNums = new int[b];
            arrNums[0] = a;
            for (int i = 1; i < arrNums.Length - 1; i++)
            {
                arrNums[i] = i + a;
            }
            arrNums[b - 1] = b;
            foreach (int i in arrNums)
            {
                Write(i + " ");
            }
            WriteLine();
        }
        static void Meth(char a, char b)
        {
            int n = (int)b - 64;
            char[] arrSymbs = new char[n];
            arrSymbs[0] = a;
            for (int i = 1; i < arrSymbs.Length-1; i++)
            {
                arrSymbs[i] = (char)(i + 65);
            }
            arrSymbs[n-1] = b;
            foreach (char i in arrSymbs)
            {
                Write(i + " ");
            }
            WriteLine();
        }
    }
}
