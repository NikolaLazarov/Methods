using System;
using static System.Console;

namespace Задача_4
{
    class Program
    {
        static void meth(char[] arrSymbol)
        {
            int[] arrCode = new int[arrSymbol.Length];
            for (int i = 0; i < arrCode.Length; i++)
            {
                arrCode[i] = (int)arrSymbol[i];
                Write(arrCode[i]+" ");
            }
            WriteLine();
        }
        static void Main(string[] args)
        {
            char[] A = { 'A', 'B', 'C' };
            meth(A);

            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
    }
}
