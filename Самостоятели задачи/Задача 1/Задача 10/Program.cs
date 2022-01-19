using System;
using static System.Console;

namespace Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Meth("Maika ti e ",'P','E','C','H','K','A');
            WriteLine("Press any key to close...");
            ReadKey(true);
        }
        static void Meth(string txt, params char[]arrSymbs){
            arrSymbs.ToString();
            for(int i =0;i<arrSymbs.Length;i++){
                txt += arrSymbs[i];
            }
            WriteLine(txt);
        }
    }
}
