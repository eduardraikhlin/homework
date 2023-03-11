// 4. Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine($"Максимальное число равно {a}");
    }
}
else if (b > c)
{
    Console.WriteLine($"Максимальное число равно {b}");
}
else
{
    Console.WriteLine($"Максимальное число равно {c}");
}