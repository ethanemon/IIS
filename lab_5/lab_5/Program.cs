﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, a, b;
            int v, y, c; //количество повторений
            Console.WriteLine("Введите количество повторений");
            Console.WriteLine("Введите переменную x");
            y = Convert.ToInt16(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());
            a = 4; //знаменатель
            b = 6; //знаменатель
            c = 3;//степень
            v = y + 4;//общее количество повторений
            bool answer = false;
            double z = (1 / (1 * 3)) - (x / (2 * 4)) + (Math.Pow(x, 2) / (3 * 5)) - (Math.Pow(x, 3) / (4 * 6));

            while (answer != true)
            {
                for (int i = 4; i < v; i++)
                {

                    if (i % 2 == 0)
                    {
                        a++;
                        b++;
                        c++;
                        z += (Math.Pow(x, c) / (a * b));
                    }
                    else if (i % 2 != 0)
                    {
                        a++;
                        b++;
                        c++;
                        z -= (Math.Pow(x, c) / (a * b));
                    }
                    else
                    {
                        Console.WriteLine("Что-то пошло не так...");
                        break;
                    }
                }
                Console.WriteLine("Продолжить?");
                string answer_p = Console.ReadLine();
                if (answer_p == "да")
                {
                    answer = false;
                }
                else if (answer_p == "нет")
                {
                    answer = true;
                }
            }

            Console.WriteLine("z = " + z);
            Console.ReadKey();
        }
    }
}