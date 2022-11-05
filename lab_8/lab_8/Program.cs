using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_8
{
    class Triangle
    {
        private double a, b, c; //сторона треугольника

        public void Set_a(double pa) {  a = pa;}
        public double Get_a() { return a;}

        public void Set_b(double pb) {b = pb;}
        public double Get_b() { return b; }

        public double GetHypo()
        {
            return c = Math.Pow(a + b, 1 / 2);
        }

        public double GetP()
        {
            return a + b + c;
        }

        public double GetS()
        {
            return  a * b* 0.5;
        }

        public void PrintInformatoion()
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <= a; j++)
                {
                    string str = "* \n" +
                                        "** \n" +
                                        "*** \n" +
                                        "**** \n" +
                                        "***** \n";
                    Console.WriteLine(str);
                }
            }

            Console.WriteLine("Прямоугольный треугольник");

            Console.WriteLine("Стороны прямоугольного треугольника: \n" +
                                               "гипотенуза = {0}" +
                                               "катет 1 = {1} " +
                                               "катет 2 = {2}", a, "5.0", c);

            Console.WriteLine("Периметр {0}", GetP());

            Console.WriteLine("Площадь {0}", GetS());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Прямоугольный треугольник";
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Triangle p;

            p = new Triangle();
            p.Set_a(5.0);
            p.Set_b(5.0);

            p.PrintInformatoion();

            Console.ReadKey();
        }
    }
}