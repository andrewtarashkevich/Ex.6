using System;

namespace Ex._6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5) Фирма имеет 10 магазинов.
            //Доходы каждого магазина за полугодие (6 месяцев с номерами 0-5) хранятся в двумерном вещественном массиве.
            //Заполнить массив случайными вещественными числами. Высчитать:
            //а) суммарный доход по каждому магазину;
            //б) средний доход по каждому месяцу;
            //в) мин.и макс. доход за весь период.
          
            double[,] arr = new double[10, 6];
            double[] average = new double[6];
            double min = double.MaxValue;
            double max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                double sum = 0;                
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Random rnd = new Random();
                    arr[i, j] = Math.Round((double)rnd.NextDouble()*100, 2);
                    Console.Write($"{arr[i, j]}\t");
                    sum += arr[i, j];
                    average[j] += arr[i, j];
                    if (arr[i, j] < min) min = arr[i, j];
                    if (arr[i, j] > max) max = arr[i, j];
                }
                Console.Write($"    Сумма за год = {Math.Round((double)sum, 2)}");
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Red;            
            for (int i = 0; i < average.Length; i++)
            {                
                Console.Write($"{Math.Round((average[i]/10),2)}   ");                
            }            
            Console.ResetColor();

            Console.WriteLine($"Мин = {min}, макс = {max}");
        }
    }
}
