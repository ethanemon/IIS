using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_2
{
    class Program
    {
        static void Main(string[]args)
        {
            int g = 10, h = 4, q = 9, b=6;
            double x = 3.4, y = 7.1, w = 8.9;
            double q3 = Math.Pow(9, 3);

            Console.WriteLine("Значение переменной g = " + g);
            Console.WriteLine("Значение переменной h = " + h);
            Console.WriteLine("Значение переменной q = " + q);
            Console.WriteLine("Значение переменной x = " + x);
            Console.WriteLine("Значение переменной y = " + y);
            Console.WriteLine("Значение переменной w = " + w);
            Console.WriteLine("Значение переменной b = " + b);
            Console.WriteLine("Значение переменной с = ");

            Console.WriteLine( g * h + b * q3 - x + y / w);

            Console.ReadKey();
           
        }
    }
}