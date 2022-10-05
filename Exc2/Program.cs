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
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість стовпців: ");
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[m, n];
            Console.WriteLine("Введіть елементи масиву");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Елемент [{i}][{j}]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Ваша матриця: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j]);
                Console.WriteLine();
            }

            int min = arr[0, 0];
            int row = 0;
            int col = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        row = i;
                        col = j;
                    }
                }
            }

            int newi, newj;
            int[,] arrNew = new int[m - 1, n - 1];
            for (int i = 0; i < arrNew.GetLength(0); i++)
            {
                newi = i >= row ? (i + 1) : i;
                for (int j = 0; j < arrNew.GetLength(1); j++)
                {
                    newj = j >= row ? (j + 1) : j;
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
