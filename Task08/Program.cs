// 8. Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите натуральное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (a > 0)
{
    if (a == 1)
    {
        Console.WriteLine($"Четные числа в данном диапозоне отсутствуют");
    }
    while (count <= a)
    {
        Console.Write($"{count} ");
        count += 2;
    }
}
else
{
    Console.WriteLine("Вы ввели не натуральное число, попробуйте еще раз!");
}