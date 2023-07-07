﻿// Напишите программу, которая по 
// заданному номеру четверти, показывает диапозон 
// возможных координат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());

string range = Range(number);
string result = range == null
                ? "Указана неверная четверть"
                : $"Диапозон возможных координат точек в этой четверти -> {range}";


Console.WriteLine (result);

string Range(int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return null;
}
