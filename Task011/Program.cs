﻿// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random ().Next(100, 1000); 
Console.WriteLine ($"Случайное трехзначное число {number}");
int fistDigit = number/ 100;
int lastDigit = number % 10;

int sum = fistDigit*10 + lastDigit; 
Console.WriteLine ($"Случайное трехзначное число без второй цифры = {sum}");
