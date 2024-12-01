using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    ///Задача 7. Определить статический метод double Average (int m, int n),
    ///который вычисляет и возвращает среднее арифметическое всех целых от m до n включительно. Используя этот метод, вычислить среднее арифметическое всех чисел:
    ///а) от 1 до 10;
    ///б) от 20 до 40;
    ///в) от a до b(a, b вводятся с клавиатуры).
    /// </summary>
    class Program
    {
        static double Average(int m, int n)
        {
            return (m + n) / 2.0;
        }
     
        static void Main(string[] args)
        {
            double average1 = Average(1, 10);
            Console.WriteLine($"среднее а= {average1}");
            double average2 = Average(20, 40);
            Console.WriteLine($"среднее б= {average2}");
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            try
            {
                double average3 = Average(a, b);
                Console.WriteLine($"Среднее арифметическое от {a} до {b}: {average3}");
            }
            catch
            {
            }
            Console.ReadKey();
        }
    }
}
