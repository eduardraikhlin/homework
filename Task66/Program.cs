// 66. Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write($"Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > 0 && number2 > 0) 
{
   if (number1 >= number2) Console.WriteLine(SumElements(number2, number1));
   else Console.WriteLine(SumElements(number1, number2));
}
else Console.WriteLine("Ошибка. Введите натуральные числа");

 int SumElements(int numA, int numB)
  {
    if (numA > numB) return 0;
    else return numA + SumElements(numA + 1, numB);
  }
    