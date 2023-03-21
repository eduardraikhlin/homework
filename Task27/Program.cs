// 27. Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number);
if (number < 0)
{
    sumDigits = -sumDigits;
}
Console.WriteLine($"Сумма цифр в числе {number} равна {sumDigits}");

int SumDigits (int num)
{
    int sum = 0;
    while (num > 0 || num < 0)
    {
    int remainer = num % 10;
    sum = sum + remainer;
    num /= 10;
    }
    return sum;
}