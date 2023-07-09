// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите целое пятизначное число: ");
string number = Console.ReadLine();

FiveNumbers(number);

void FiveNumbers(string num)
{
    int len = num.Length;
    if (len == 5)
    {
        if (num[0] == num[4] && num[1] == num[3])
        {
            Console.WriteLine($"{num} Палиндром");
        }
        else
        {
            Console.WriteLine($"{num} Не Палиндром");
        }
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}
