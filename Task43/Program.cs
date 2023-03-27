// 43. Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение коэффициента k1: ");
double numk1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение коэффициента k2: ");
double numk2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение коэффициента b1: ");
double numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение коэффициента b2: ");
double numb2 = Convert.ToInt32(Console.ReadLine());

double xCoordinate = xCoordinateTwoLines (numk1, numk2, numb1, numb2);
double resultX = Math.Round(xCoordinate, 1);
double yCoordinate = yCoordinateTwoLines (numk1, numb1, xCoordinate);
double resultY = Math.Round(yCoordinate, 1);
Console.WriteLine($"Точка пересечения двух прямых, заданных уравнением, имеет координаты: ({resultX}; {resultY})");

double xCoordinateTwoLines (double k1, double k2, double b1, double b2)
{
    return (b2-b1)/(k1-k2);
}

double yCoordinateTwoLines (double k1, double b1, double x)
{
   return  k1 * x + b1;
}