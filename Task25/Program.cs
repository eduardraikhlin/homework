// 25. Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число В: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = Degree(a, b);
if (b == 0)
{
    Console.WriteLine($"Число {a} в степени {b} равно 1");
}
else if (b == 1)
{
    Console.WriteLine($"Число {a} в степени {b} равно {a}");
}
else if (b < 0)
{
   Console.WriteLine("Ошибка. Введите натуральную степень"); 
}
else
{
    Console.WriteLine($"Число {a} в степени {b} равно {result}");
}


int Degree(int num1, int num2)
{
    int result = 1;
    for (int i = 0; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}