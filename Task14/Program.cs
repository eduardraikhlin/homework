// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

bool result = MultTwoNumbers(number1, 7, 23);
Console.WriteLine(result ? "Да" : "Нет");

bool MultTwoNumbers (int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}
