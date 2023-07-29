// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] CreateMatrixRndInt(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = 3
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) //  matrix.GetLength(1) = 4
        {
            Console.Write($"{matrix[i, j],6} ");
        }
        Console.WriteLine("|");
    }
}

double MediumSumNumbers(double[,] matrix)
{
    
    double[] avgNumbers = new double[matrix.GetLength(1)];

for (int i = 0; i < matrix.GetLength(1); i++)
{
    double result = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        result += matrix[j, j];
    }
    avgNumbers[i] = result / matrix.GetLength(1);
}
return avgNumbers [0];
}

    double[,] array2d = CreateMatrixRndInt(2, 2);
    PrintMatrix(array2d);
    double MediumSum = MediumSumNumbers(array2d);
    Console.WriteLine($"Среднее арифметическое элементов в каждом столбце: {MediumSum}");