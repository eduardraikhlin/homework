// 10. Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

if (threeDigitNumber > 99 && threeDigitNumber < 1000)
{
    int result = RemainSecondDigit(threeDigitNumber);
    Console.WriteLine($"Вторая цифра числа {threeDigitNumber} равна: {result}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число! Попробуйте еще раз.");
}

int RemainSecondDigit(int threeDigitNum)
{
    int remainSecondDigit = threeDigitNum / 10 % 10;
    return remainSecondDigit;
}