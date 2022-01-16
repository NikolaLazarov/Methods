using System;
using static System.Console;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] babaGanq = { 1, 2, 3, 4, 5, 6 };
            WriteLine("The array before: ");
            foreach (int i in babaGanq)
            {
                Write(i + " ");
            }
            WriteLine();

            WriteLine("The array after: ");
            pechki(babaGanq);


            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
        static void pechki(int[] babaGanq)
        {
            int temp = 0;
            for (int i = 0; i < babaGanq.Length / 2; i++)
            {
                temp = babaGanq[i];
                babaGanq[i] = babaGanq[babaGanq.Length - (i + 1)];
                babaGanq[babaGanq.Length - (i + 1)] = temp;
            }
            foreach (int i in babaGanq)
            {
                Write(i + " ");
            }
            WriteLine();
        }
    }
}
