using System;

namespace Ex._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Поменять знак на противоположный у всех элементов, расположенных по краям двумерного массива NxM.
            //Изменяющиеся элементы должны образовать "рамочку" толщиной в 1 элемент.
            //Задание 1

            int[,] arr = new int[4, 3];
            Console.WriteLine("Original array:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Random rnd = new Random();
                    arr[i, j] = rnd.Next(1, 100);
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Updated array:");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0 || i == (arr.GetLength(0) - 1))
                    {
                        arr[i, j] = arr[i, j] * -1;
                    }
                    else
                    {
                        arr[i, 0] = arr[i, 0] * -1;
                        arr[i, (arr.GetLength(1) - 1)] = -1 * arr[i, (arr.GetLength(1) - 1)];
                    }
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
