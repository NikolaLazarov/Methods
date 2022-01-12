using System;
using static System.Console;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] A = {'A','B','C'};
            Meth(A);

            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
        static void Meth(char[] arrSymbs){
            foreach(var i in arrSymbs){
                WriteLine((int)i);
            }
        }
    }
}
