using System;

namespace Ex._6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Найти количество элементов массива, которые больше всех своих соседей одновременно. 
            //Примечание: соседями элемента считать только 4 потенциальных соседа: на 1 выше, на 1 ниже, на 1 левее и на 1 правее.
            //Обязательно учесть выход за границы массива!При определении критерия, считать сумму соседей для каждого элемента, даже для элемента[0; 0]
            //(у него, кстати, будет всего два соседа - [0; 1] и[1; 0]).

            int[,] arr = new int[3,3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Random rnd = new Random();
                    arr[i, j] = rnd.Next(0, 6);
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }


            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        if (arr[i, j] > (arr[i + 1, j] + arr[i, j + 1]))
                            count += 1;
                    }
                    else if (i == (arr.GetLength(0) - 1) && j == 0)
                    {
                        if (arr[i, j] > (arr[i, j+1] + arr[i-1, j]))
                            count += 1;
                    }
                    else if (i == 0 && j == (arr.GetLength(1) - 1))
                    {
                        if (arr[i, j] > (arr[i, j-1] + arr[i+1, j]))
                            count += 1;
                    }
                    else if (j == arr.GetLength(1) - 1 && i == arr.GetLength(0) - 1)
                    {
                        if (arr[i, j] > (arr[i - 1, j] + arr[i, j - 1]))
                            count += 1;
                    }

                    else if (i == 0 && j != 0 && j != arr.GetLength(1) - 1)
                    {
                        if (arr[i, j] > (arr[i, j - 1] + arr[i + 1, j] + arr[i, j + 1]))
                            count += 1;
                    }
                    else if (i != (arr.GetLength(0) - 1) && i != 0 && j == 0)
                    {
                        if (arr[i, j] > (arr[i + 1, j] + arr[i-1, j] + arr[i, j + 1]))
                            count += 1;
                    }
                    else if (j != 0 && i == (arr.GetLength(0) - 1) && j != arr.GetLength(1) - 1)
                    {
                        if (arr[i, j] > (arr[i - 1, j] + arr[i, j+1] + arr[i, j - 1]))
                            count += 1;
                    }
                    else if (j == arr.GetLength(1) - 1 && i != arr.GetLength(0) - 1 && i != 0)
                    {
                        if (arr[i, j] > (arr[i - 1, j] + arr[i+1, j] + arr[i, j - 1]))
                            count += 1;
                    }
                    else
                    {
                        if (arr[i, j] > (arr[i - 1, j] + arr[i + 1, j] + arr[i, j - 1] + arr[i, j + 1]))
                            count += 1;
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine(count);
        }
    }
}
