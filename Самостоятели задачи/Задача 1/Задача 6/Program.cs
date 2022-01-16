using System;
using System.Linq;
using static System.Console;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrNums = new int[2, 3];
            Random rnd = new Random();
            WriteLine("The array: ");
            for (int i = 0; i < arrNums.GetLength(0); i++)
            {
                for (int j = 0; j < arrNums.GetLength(1); j++)
                {
                    arrNums[i, j] = rnd.Next(1, 9);
                    Write(arrNums[i, j] + " ");
                }
                WriteLine();
            }

            Meth(arrNums);
            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
        static void Meth(int[,] arrNums)
        {
            int min, max;
            max = arrNums[0, 0];
            int y = 0, x = 0;
            for (int i = 0; i < arrNums.GetLength(0); i++)
            {
                for (int j = 0; j < arrNums.GetLength(1); j++)
                {
                    if (arrNums[i, j] > max)
                    {
                        max = arrNums[i, j];
                        y = i;
                        x = j;
                    }
                }
            }
            WriteLine("The max value: " + max);
            WriteLine("Index of max value: " + "[" + x + ", " + y + "]");
        }
    }
}
