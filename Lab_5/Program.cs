using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість рядків: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть кількість стовпців: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[m, n];
            Console.WriteLine("Введіть елементи масиву");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Елемент [{i}][{j}]: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Ваша матриця: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j]);
                Console.WriteLine();
            }

            int max = arr[0, 0];
            int row = 0;
            int col = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        row = i;
                        col = j;
                    }
                }
            }

            int newi, newj;
            int[,] arrNew = new int[m - 1, n - 1];
            for (int i = 0; i < arrNew.GetLength(0); i++)
            {
                newi = i;
                if (i >= row)
                    newi = i + 1;
                for (int j = 0; j < arrNew.GetLength(1); j++)
                {
                    newj = j;
                    if (j >= col)
                        newj = j + 1;
                    arrNew[i, j] = arr[newi, newj];
                }
            }
            Console.WriteLine();

            Console.WriteLine("Новий масив: ");
            for (int i = 0; i < arrNew.GetLength(0); i++)
            {
                for (int j = 0; j < arrNew.GetLength(1); j++)
                    Console.Write(arrNew[i, j]);
                Console.WriteLine();
            }

            Console.Read();
        }


    }
}
