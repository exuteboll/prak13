using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Task 1  Найти минимальную величину из двух целых переменных a, b,
    /// используя вспомогательные методы (ввода аргументов, нахождения минимальной величины, вывода результата).
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
            int x = Input("x= ");
            int y = Input("y= ");
            int z = Input("z= ");
            int min = Min(Min(x, y), z);
            Console.WriteLine($"Минимальное значение = {min}");
            Console.ReadKey();
        }
    }
}
