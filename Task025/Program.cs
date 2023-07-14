// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите целое положительное число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA <= 0 && numberB <= 0)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}


int degreeNumber = DegreeNumber(numberA, numberB);
Console.WriteLine($"Натуральное число {numberA} в степени {numberB} = {degreeNumber}");

int DegreeNumber(int numA, int numB)
{
    int sum = 1;
    for (int i = 1; i <= numB; i++)
    {
        sum *= numA;
    }
    return sum;
}