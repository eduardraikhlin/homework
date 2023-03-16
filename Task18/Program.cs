// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
string quarterNum = Console.ReadLine();

string result = RangeCoordinates(quarterNum);

Console.WriteLine (result);

string RangeCoordinates (string quarter)
{
    if (quarter == "1") return "x > 0, y > 0";
    if (quarter == "2") return "x < 0, y > 0";
    if (quarter == "3") return "x < 0, y < 0";
    if (quarter == "4") return "x > 0, y < 0";
    return "Такой четверти не существует";
}