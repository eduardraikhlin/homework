// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double d = Math.Sqrt(5);
// double res = 5.099987564;
// double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
// Console.WriteLine(resRound);

Console.Write("Введите координату первой точки по х: ");
int num1X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки по y: ");
int num1Y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату второй точки по х: ");
int num2X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки по y: ");
int num2Y = Convert.ToInt32(Console.ReadLine());

double result = Distance (num1X, num1Y, num2X, num2Y);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками равно {resultRound}");

double Distance (int x1, int y1, int x2, int y2)
{
     int x = x1 - x2;
     int y = y1 - y2;
     double c = Math.Sqrt(x*x+y*y);
     return c;    
}


