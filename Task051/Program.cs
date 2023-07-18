﻿// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    //                        0       1
    int[,] matrix = new int[rows, columns]; // 3 x 4

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //  matrix.GetLength(1) = 4
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = 3
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) //  matrix.GetLength(1) = 4
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

int SumElemDiagonalMatrix(int[,] matrix)
{
    int sum = 0;
    // int size = matrix.GetLength(0);
    // if (size > matrix.GetLength(1)) size = matrix.GetLength(1);

    // for (int i = 0; i < size; i++)
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++) 
    {
        sum += matrix[i, i];
    }

    return sum;
}

int[,] array2d = CreateMatrixRndInt(4, 3, 1, 9);
PrintMatrix(array2d);
int sumElem = SumElemDiagonalMatrix(array2d);
Console.WriteLine($"Сумма элементов главной диагонали: {sumElem}");