﻿using System;

namespace Ex._6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Зрительный зал театра имеет N рядов по M мест в каждом ряду.
            //Их можно представить в виде двумерного массива NxM. Если место занято - в массиве стоит значение "1". Если свободно - "0".
            //Образец массива задать вручную, инициализацией в момент создания.
            //На готовом массиве проверить соблюдение "антиковидного правила"
            //(нет двух занятых мест в одном ряду, расположенных рядом, но пропусков может быть сколько угодно).
            //Сделать по оптимальному алгоритму (если нашли два занятых кресла рядом в одном ряду - прервать циклы обхода матрицы).
            int[,] arr = new int[13, 3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Random rnd = new Random();
                    arr[i, j] = rnd.Next(0,2);
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        if (arr[i, j] == 1 && arr[i, j+1] == 1)
                        {
                            Console.WriteLine($"Обнаружены нарушители антиковидных мер: ряд {i}, место {j}");
                            return;
                        }
                    }
                    else
                    {
                        if (arr[i, j] == 1 && arr[i, j-1] == 1)
                        {
                            Console.WriteLine($"Обнаружены нарушители антиковидных мер: ряд {i}, место {j}");
                            return;
                        }
                    }
                                       
                }                
            }
        }
    }
}
