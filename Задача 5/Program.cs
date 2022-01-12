using System;
using static System.Console;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A = { 9, 3, 5, 1, 10 };
            Meth(A);
            WriteLine("Press any key to exit");
            ReadKey(true);
        }
        static void Meth(double[] arrNums)
        {
            double var = 0;
            for (int i = 0; i < arrNums.Length; i++)
            {
                var += arrNums[i];
            }
            WriteLine(var / arrNums.Length);
        }
    }
}
