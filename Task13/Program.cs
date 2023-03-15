// 13. Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    int thirdDigit = ThirdDigit(number);
    Console.WriteLine(thirdDigit);
}
else if (number < -99)
{
    number = -number;
    int thirdDigit = ThirdDigit(number);
    Console.WriteLine(thirdDigit);
}
else
{
     Console.WriteLine("В введенном числе нету третьей цифры");
}

int ThirdDigit (int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}