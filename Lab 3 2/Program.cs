using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, h;
            string Str;
            Console.Write("Введите значение основания: ");
            Str = Console.ReadLine();
            a = Convert.ToInt16(Str);
            Console.Write("Введите значение высоты: ");
            Str = Console.ReadLine();
            h = Convert.ToInt16(Str);
            double v = (1 / 3) * Math.Pow(h * a, 2);
            Console.WriteLine("Объём равен: " + v);
            Console.ReadKey();
           
        }
    }
}
