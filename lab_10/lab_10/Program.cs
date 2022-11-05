using System;
namespace example
{
    class Program
    {
        struct Fraction
        {
            public int numerator;
            public int denominator;
        }
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction();
            Console.Write("Введите числитель: ");
            fraction.numerator = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель: ");
            fraction.denominator = int.Parse(Console.ReadLine());
            fraction = ToReduce(fraction);
            Console.WriteLine("Числитель: {0}", fraction.numerator);
            Console.WriteLine("Знаменатель: {0}", fraction.denominator);
            Console.ReadKey();
        }
        static Fraction ToReduce(Fraction fraction)
        {
            int nod = Nod(fraction.numerator, fraction.denominator);
            if (nod != 0)
            {
                fraction.numerator /= nod;
                fraction.denominator /= nod;
            }
            return fraction;
        }
        static int Nod(int n, int d)
        {
            int temp;
            n = Math.Abs(n);
            d = Math.Abs(d);
            while (d != 0 && n != 0)
                {
                    if (n % d > 0)
                    {
                        temp = n;
                        n = d;
                        d = temp % d;
                    }
                    else break;
                }
            if (d != 0 && n != 0) return d;
            else return 0;
        }
    }
}