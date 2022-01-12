using System;
using static System.Console;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[3];
            Random rnd = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                int k = rnd.Next(0, 9);
                A[i] = k;
                Write(A[i]);
            }
            WriteLine();
            int B = 5;
            rndformArr(A, B);
            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
        static void rndformArr(int[] numsArr, int n)
        {
            int[] xyz = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (n > numsArr.Length)
                {
                    int[] newArr = new int[n];
                    int p = 0;
                    for (int j = 0; j < n; j++)
                    {
                        newArr[j] = numsArr[p];
                        p++;
                        if (p == numsArr.Length)
                        {
                            p = 0;
                        }
                    }
                    Write(newArr[i]);
                }
                else
                {
                    xyz[i] = numsArr[i];
                    Write(xyz[i]);
                }
            }
            WriteLine();
        }
    }
}
