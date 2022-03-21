using System;

namespace Ex._6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполнить квадратную матрицу NxN (произвольного размера) нулями и единицами так,
            //как расположены клетки на шахматной доске, где 0 - "черное", 1 - "белое".
            //Левое нижнее поле на шахматной доске всегда черное.
            //Обратите внимание - нумерация элементов массива идет сверху вниз, и слева направо.
            //То есть, левое нижнее поле - это поле в последней строке и 0-м столбце.
            int[,] arr = new int[10, 9];
            for (int i = 0; i < arr.GetLength(0); i++)
            {                
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr.GetLength(0) % 2 == 0)
                    {
                        if ((i + j) % 2 != 0) arr[i, j] = 0;
                        else arr[i, j] = 1;

                        Console.Write($"{arr[i, j]}\t");
                    }
                    else
                    {
                        if ((i + j) % 2 == 0) arr[i, j] = 0;
                        else arr[i, j] = 1;

                        Console.Write($"{arr[i, j]}\t");
                    }                    
                }
                Console.WriteLine();
            }
        }
    }
}
