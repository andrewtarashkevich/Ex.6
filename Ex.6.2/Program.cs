using System;

namespace Ex._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Заполнить матрицу 9x9 таблицей умножения:
            //      1 2 3 ...  9
            //      2 4 6... ...
            //      3 6 9... ...
            //      ...  ... ... ...
            //      9........81
            int[,] arr = new int[10,10];
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = i * j;
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
