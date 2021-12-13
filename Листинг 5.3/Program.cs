using System;
using static System.Console;

namespace Листинг_5._3
{
    class Program
    {
        static void fillRand(int[] nums)
        {
            Random rnd = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1, 10);
            }
        }
        static void showArr(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Write("| {0} ", nums[i]);
            }
            WriteLine("|");
        }
        static void showArr(int[,] nums)
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Write("{0,3}", nums[i, j]);
                }
                WriteLine();
            }
        }
        static int findMin(int[] nums)
        {
            int s = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < s)
                {
                    s = nums[i];
                }
            }
            return s;
        }
        static void Main(string[] args)
        {
            int[] A = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int[] B = new int[5];
            int[,] C = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            fillRand(B);
            showArr(B);
            int m = findMin(B);
            WriteLine("Най-малката стойност {0}", m);
            WriteLine("Думерен масив С:");
            showArr(C);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
