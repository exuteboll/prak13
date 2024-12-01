using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Определить статический метод void Numbers(int n), который выводит на экран четные числа
    ///от 2 до числа n.Используя этот метод, вывести на экран четные числа:
    ///а) от 2 до 20;
    ///б) от 2 до 50;
    ///в) от 2 до m(m вводится с клавиатуры).
    /// </summary>
    class Program
    {
        static void Numbers(int n)
        {
            for (int i = 2; i <= n; i += 2)
            {
                Console.WriteLine(i + " ");
            }
        }
     
        static void Main(string[] args)
        {
            Console.WriteLine("от 2 до 20");
            Numbers(20);
            Console.WriteLine("от 2 до 50");
            Numbers(50);
            Console.Write("Введите значение m = ");
            int m = int.Parse(Console.ReadLine());
            Numbers(m);
            Console.ReadKey();
        }
    }
}
