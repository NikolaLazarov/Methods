using System;
using System.Linq;
using static System.Console;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Meth(69,5,13,25,30,20,99);

            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
        static void Meth(params int[]refs){
            int[] minMax = new int[2];
            minMax[0]=refs.Min();
            minMax[1]=refs.Max();
            foreach(int i in minMax){
                Write(i+" ");
            }
            WriteLine();
        }
    }
}
