// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumber (number);
Console.WriteLine($"{sumNumber}");

int SumNumber (int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num /10;
    }
    return result;
}