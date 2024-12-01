using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    ///Определить статический метод int Meters(int k, int m), который принимает два целых аргумента
    ///(километры k, метры m) и возвращает количество метров. 
    ///Используя этот метод, вычислить количество метров для расстояния:
    ///а) 3 км 40 м;
    ///б) 12 км 540 м.
    /// </summary>
    class Program
    {
        static int Meters(int k, int m)
        {
            return (k * 1000) + m;
        }
        static int Input(string x)
        {
            Console.Write(x);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int k = Input("kilometers = ");
            int m = Input("meters = ");
            int mt = Meters(k, m);
            Console.WriteLine($"Общее кол-во метров = {mt}");
            Console.ReadKey();
        }
    }
}
