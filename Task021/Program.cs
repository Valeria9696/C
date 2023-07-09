// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты X точки 1:");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки 1:");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z точки 1:");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X точки 2:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки 2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z точки 2:");
int b3 = Convert.ToInt32(Console.ReadLine());

double result = Distance(a1, a2, a3, b1, b2, b3);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero); // Math.Round - возвращает число, округлённое к ближайшему целому
// MidpointRounding.ToZero - параметр округления
Console.WriteLine ($"Расстояние между точками: {resultRound}");


double Distance(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    int cat1 = X1 - X2;
    int cat2 = Y1 - Y2;
    int cat3 = Z1 - Z2;
    double dist = Math.Sqrt(cat1 * cat1 + cat2 * cat2 + cat3 * cat3); // Math.Sqrt - математическая функция которая извлекает квадратный корень. 
    return dist;
}
