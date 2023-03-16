// 19. Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());

if (fiveDigitNumber > 9999 && fiveDigitNumber < 100000
    || fiveDigitNumber < -9999 && fiveDigitNumber > -100000)
{
    bool result = Palindrom (fiveDigitNumber);
    Console.WriteLine(result ? "Да, введенное число является палиндромом" 
                             : "Нет, введенное число не является палиндромом");
}
else
{
    Console.WriteLine("Ошибка. Введите пятизначное число!");
}

bool Palindrom (int number)
{
    int firstDigit = number / 10000;
    int secondDigit = number / 1000 % 10;
    int fourthDigit = number / 10 % 10;
    int fifthDigit = number % 10;
    return firstDigit == fifthDigit && secondDigit == fourthDigit;
}