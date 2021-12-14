using System;
using static System.Console;

namespace Листинг_5._4
{
    class Program
    {
        static int[] fibs(int n)
        {
            int[] nums = new int[n];
            nums[0] = 1;
            if (nums.Length == 1)
            {
                return nums;
            }
            nums[1] = 1;
            for (int i = 2; i < nums.Length; i++)
            {
                nums[i] = nums[i - 1] + nums[i - 2];
            }
            return nums;
        }
        static char[] rands(int n)
        {
            Random rnd = new Random();
            char[] symbs = new char[n];
            for (int i = 0; i < symbs.Length; i++)
            {
                symbs[i] = (char)('A' + rnd.Next(26));
            }
            return symbs;
        }
        static int[,] odds(int m, int n)
        {
            int[,] nums = new int[m, n];
            int val = 1;
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = val;
                    val += 2;
                }
            }
            return nums;
        }
        static void Main(string[] args)
        {
            int[] A;
            char[] B;
            int[,] C;

            A = fibs(10);
            WriteLine("Числата на Фибоначи: ");
            foreach (int s in A)
            {
                Write("| {0} ", s);
            }
            WriteLine();

            B = rands(8);
            WriteLine("Случайни синволи: ");
            foreach (char s in B)
            {
                Write("| {0} ", s);
            }
            WriteLine();

            C = odds(4, 6);
            WriteLine("Друмерен масив: ");
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    Write("{0,4}", C[i, j]);
                }
                WriteLine();
            }
            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
