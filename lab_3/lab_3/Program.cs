using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_3
{
    class Program
    {
        static void Main(string[]args)
        {
            int g, h, b;
            double q, x, y, w, c;
            g = Convert.ToInt16(Console.ReadLine());
            h = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            q = Convert.ToDouble(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            w = Convert.ToDouble(Console.ReadLine());

            c = Math.Cos(g * h) + b * Math.Pow(q, 1 / 3) - Math.Abs(x - y) / w;
          
            Console.WriteLine("Денежный формат {0:C} \n", c);
            //Console.WriteLine("Десятичный формат {0:D10} \n", c);
            Console.WriteLine("Экспоненциальный  формат {0:E} \n", c);
            Console.WriteLine("Формат с фиксированной запятой  {0:F3, 7} \n", c);
            Console.WriteLine("Общий формат  {0:G} \n", c);
            Console.WriteLine("Числовой формат {0:N} \n", c);
            Console.WriteLine("Процентный формат  {0:P} \n", c);
           // Console.WriteLine("Шестнадцатиричный формат  {0:X} \n", c);


            Console.ReadKey();
        }
    }
}