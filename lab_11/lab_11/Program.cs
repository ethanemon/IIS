using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_11
{
    class Matrix
    {
        public int[,] array { get; private set; }
        public Matrix(int[,] array)
        {
            this.array = array;
        }
        public static Matrix operator +(Matrix x1, Matrix x2)
        {
            if (x1.array.Length == x2.array.Length)
            {
                var array2 = new int[x1.array.GetLength(0), x1.array.GetLength(1)];
                for (int i = 0; i < x1.array.GetLength(0); i++)
                {
                    for (int j = 0; j < x1.array.GetLength(1); j++)
                    {
                        array2[i, j] = x1.array[i, j] + x2.array[i, j];
                    }
                }
                return new Matrix(array2);
            }
            return null;
        }

        public static Matrix operator -(Matrix x1, Matrix x2)
        {
            if (x1.array.Length == x2.array.Length)
            {
                var array2 = new int[x1.array.GetLength(0), x1.array.GetLength(1)];
                for (int i = 0; i < x1.array.GetLength(0); i++)
                {
                    for (int j = 0; j < x1.array.GetLength(1); j++)
                    {
                        array2[i, j] = x1.array[i, j] - x2.array[i, j];
                    }
                }
                return new Matrix(array2);
            }
            return null;
        }

        public static Matrix operator *(Matrix x1, Matrix x2)
        {
            if (x1.array.Length == x2.array.Length)
            {
                var array2 = new int[x1.array.GetLength(0), x1.array.GetLength(1)];
                for (int i = 0; i < x1.array.GetLength(0); i++)
                {
                    for (int j = 0; j < x1.array.GetLength(1); j++)
                    {
                        array2[i, j] = x1.array[i, j] * x2.array[i, j];
                    }
                }
                return new Matrix(array2);
            }
            return null;
        }
    
}
    class Program
    {
        static void Main()
        {
            Matrix matrix = new Matrix(new int[,] { { 1, 2, 3 }, { 4, 5, 6 } });
            Matrix matrix2 = new Matrix(new int[,] { { 1, 2, 3 }, { 4, 5, 6 } });
            Matrix matrix3 = matrix + matrix2;
           
            for (int i = 0; i < matrix3.array.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3.array.GetLength(1); j++)
                {
                    Console.Write(matrix3.array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}