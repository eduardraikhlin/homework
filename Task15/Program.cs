// 15. Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    bool weekendFinder = WeekendFinder (number);
    Console.WriteLine(weekendFinder ? "Да, это выходной" : "Нет, это будний день");
}
else
{
    Console.WriteLine("Вы ввели цифру, не соответствующую дням недели");
}

bool WeekendFinder (int num)
{
    return num > 5 && num < 8;
}