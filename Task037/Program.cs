// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)
{
  int[] arr = new int[size];
  Random rnd = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(min, max + 1);
  }
  return arr;
}

void PrintArray(int[] arr, string sep = ", ")
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep}");
    else Console.Write($"{arr[i]}");
  }
}

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] ProductPairsNumbers(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 != 0)
    {
        newArr[size - 1] = arr[arr.Length / 2];
    }
    return newArr;
}

int[] array = CreateArrayRndInt(6, 1, 9);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();

int[] resArr = ProductPairsNumbers(array);
Console.Write("[");
PrintArray(resArr);
Console.Write("]");


// double[] CreateArrayRndDouble(int size, int min, int max)
// {
//     double[] arr = new double[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.NextDouble() * (max - min) + min;
//     }
//     return arr;
// }

// void PrintArrayDouble(double[] arr, string sep = ", ", int round = 1)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         double num = Math.Round(arr[i], round);
//         if (i < arr.Length - 1) Console.Write($"{num}{sep}");
//         else Console.Write($"{num}");
//     }
// }