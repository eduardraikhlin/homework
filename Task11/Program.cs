// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int RemoveSecondDigit(int num) // num = number
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
} 

int number = new Random().Next(100,1000);
int removeSecondDigit = RemoveSecondDigit(number);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");

Console.WriteLine($"После удаления второй цифры, получим число -> {removeSecondDigit}");