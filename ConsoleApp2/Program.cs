using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int Min(int x, int y)
        {
            return x < y ? x : y;
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Output(int min)
        {
            Console.WriteLine(min);
        }
        static void Main(string[] args)
        {
            int x = Input("a=");
            int y = Input("b=");
            int min = Min(x, y);
            Output(min);

            Console.ReadKey();
        }
    }
}
