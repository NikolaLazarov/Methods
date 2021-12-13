using System;
using static System.Console;

namespace Листинг_5._2
{
    class Program
    {
        static void show(string text)
        {
            WriteLine(text);
        }
        static void show(int num)
        {
            WriteLine("Цяло число: " + num);
        }
        static void show(double num)
        {
            WriteLine("Реално число: " + num);
        }
        static void show(char s)
        {
            WriteLine("Синвол:" + s);
        }
        static void show(int num, char s)
        {
            WriteLine("Аргументи {0} и {1}", num, s);
        }
        static void Main(string[] args)
        {
            int num = 5;
            double z = 12.5;
            char symb = 'W';
            show(symb);
            show("Запознаваме се с презареждането на методи");
            show(num);
            show(z);
            show(num, 'Q');

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
