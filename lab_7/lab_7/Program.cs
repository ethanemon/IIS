using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, a, b;
            Console.WriteLine("Введите x");
            x = Convert.ToDouble(Console.ReadLine());
            double z = (1 / (1 * 3)) - (x / (2 * 4)) + (Math.Pow(x, 2) / (3 * 5)) - (Math.Pow(x, 3) / (4 * 6));
            bool answer = false;
            a = 4;
            b = 6;
            int c = 3;
            int num = 0;

            do
            {
                if (c % 2 != 0)
                {
                    a++;
                    b++;
                    c++;
                    z += (Math.Pow(x, c) / (a * b));
                }
                else if (c % 2 == 0)
                {
                    a++;
                    b++;
                    c++;
                    z -= (Math.Pow(x, c) / (a * b));
                }

                num++;
                Console.WriteLine("Номер итерации " + num);

                Console.WriteLine("Продолжить? (1- да, 0 - нет)");
                string text = Console.ReadLine();

                if (text == "1")
                {
                    answer = false;
                }
                else if (text == "0")
                {
                    answer = true;
                    Console.WriteLine("z =" + z);
                    break;
                }
            }
            while (answer != true);
            Console.ReadKey();
        }
    }
}