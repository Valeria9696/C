// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние
// между ними в 2D пространтсве.

// А (3,6); В (2,1) -> 5,09
// А (7,-5); В (1,-1) -> 7, 21

Console.WriteLine ("Введите координаты X точки 1:");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты Y точки 1:");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты X точки 2:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты Y точки 2");
int b2 = Convert.ToInt32(Console.ReadLine());

double result = Distance (a1, a2, b1, b2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine ($"Расстояние между точками: {resultRound}");

double Distance (int X1, int Y1, int X2, int Y2)
{
    int cat1 = X1 -X2;
    int cat2 = Y1 - Y2;
    double dist = Math.Sqrt (cat1 * cat1 + cat2 * cat2);
    return dist;
}