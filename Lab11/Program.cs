using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторна робота №11. Взаємодія з користувачем шляхом механізму введення/виведення \n Виконав студент КН-923а Тиртишний Ярослав");

            double[,] matrix1 = new double[3, 3];
            double[,] matrix2 = new double[3, 3];

            InputMatrix(matrix1, "A");
            InputMatrix(matrix2, "B");

            Console.WriteLine("\nМатриця A:");
            PrintMatrix(matrix1);
            Console.WriteLine("\nМатриця B:");
            PrintMatrix(matrix2);

            double[,] result = AddMatrices(matrix1, matrix2);

            Console.WriteLine("\nСума матриць A та B:");
            PrintMatrix(result);
        }

        static void InputMatrix(double[,] matrix, string prompt)
        {
            Console.WriteLine($"Введіть матрицю {prompt}:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i}][{j}]: ");
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[i, j]:F2} ");
                }
                Console.WriteLine("]");
            }
        }

        static double[,] AddMatrices(double[,] matrix1, double[,] matrix2)
        {
            double[,] result = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }
    }
}
