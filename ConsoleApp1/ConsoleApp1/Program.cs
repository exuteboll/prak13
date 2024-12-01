using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    ///Task 3 Найти s = min(a, b) + min(c, d), 
    ///используя вспомогательные функции(ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    class Program
    {
        static int Min(int x, int y)
        {
            return x < y ? x : y;
        }
        static int Input(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int a = Input("a = ");
            int b = Input("b = ");
            int c = Input("c = ");
            int d = Input("d = ");
            int s = Min(a, b) + Min(c, d);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
