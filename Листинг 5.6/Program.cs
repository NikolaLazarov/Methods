using System;
using static System.Console;

namespace Листинг_5._6
{
    class Program
    {
        static void alpha(ref int n)
        {
            WriteLine("В метод alpha(). На вход," + n);
            n++;
            WriteLine("В метод alpha(). На изход," + n);
        }
        static void barvo(ref int[] n)
        {
            WriteLine("В метод bravo(). На вход:" + ArrayToText(n));
            for (int i = 0; i < n.Length; i++)
            {
                n[i]++;
            }
            WriteLine("В метод bravo(). На изход: " + ArrayToText(n));
        }
        static void charlie(ref int[] n)
        {
            WriteLine("В метод charlie(). На вход: " + ArrayToText(n));
            int[] m = new int[n.Length];
            for (int i = 0; i < n.Length; i++)
            {
                m[i] = n[i] + 1;
            }
            n = m;
            WriteLine("В метод charlie(). На изход: " + ArrayToText(n));
        }
        static string ArrayToText(int[] n)
        {
            string res = "[" + n[0];
            for (int i = 1; i < n.Length; i++)
            {
                res += "," + n[i];
            }
            res += "]";
            return res;
        }
        static void Main(string[] args)
        {
            int A = 100;

            WriteLine("До извикване на метода alpha: A = " + A);
            alpha(ref A);
            WriteLine("След извъкване на метода alpha: A = " + A);

            int[] B = { 1, 3, 5 };
            WriteLine("До извикване на метода bravo() :B = " + ArrayToText(B));
            barvo(ref B);
            WriteLine("След извикване на метода bravo() :B = " + ArrayToText(B));

            int[] C = { 2, 4, 6 };
            WriteLine("До извикване на метод charlie(): C = " + ArrayToText(C));
            charlie(ref C);
            WriteLine("След извикване на метода charlie(): C = " + ArrayToText(C));

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
