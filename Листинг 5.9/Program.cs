using System;
using static System.Console;

namespace Листинг_5._9
{
    class Program
    {
        static int sum(params int[] a)
        {
            int res = 0;
            for (int k = 0; k < a.Length; k++)
            {
                res += a[k];
            }
            return res;
        }
        static string getText(string t, params int[] a)
        {
            string res = "";
            for (int k = 0; k < a.Length; k++)
            {
                res += t[a[k]];
            }
            return res;
        }
        static void show(int[] a, params char[] b)
        {
            Write("Числа " + a.Length + ": ");
            for (int k = 0; k < a.Length - 1; k++)
            {
                Write(a[k] + " ");
            }
            WriteLine("и " + a[a.Length - 1]);
            Write("Символи " + b.Length + ": ");
            for (int k = 0; k < b.Length - 1; k++)
            {
                Write(b[k] + " ");
            }
            WriteLine("и " + b[b.Length - 1]);
        }
        static void Main(string[] args)
        {
            WriteLine("Сумата на числата : " + sum(1, 6, 9, 2, 4));
            WriteLine("Сумата на числата : " + sum(5, 1, 2));
            WriteLine(getText("Раз два три", 0, 10, 8, 1));
            WriteLine(getText("Гарван", 3, 1, 2, 5, 4));

            show(new int[] { 1, 3, 5 }, 'A', 'B', 'C', 'D', 'E');
            show(new int[] { 1, 3, 5, 7, 9 }, 'A', 'B', 'C', 'D');

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
