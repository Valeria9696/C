// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random ().Next(10, 99 +1); 
Console.WriteLine ($"Случайное число 10-99 -> {number}");

int fistDigit = number / 10; 
int secondDigit = number % 10;

if (fistDigit > secondDigit)
{
    Console.WriteLine ($"Наибольшая цифра числа: {fistDigit}");
}
else if (fistDigit < secondDigit)
{
Console.WriteLine ($"Наибольшая цифра числа: {fistDigit}");
}
else
{
    Console.WriteLine ("Одинаковые числа");
}
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");