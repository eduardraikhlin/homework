// 68. Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int m = 3;
int n = 11;

int result = Ackermann(m, n);
Console.WriteLine(result);

int Ackermann(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if (num2 == 0) return Ackermann(num1 - 1, 1);
    return Ackermann (num1 - 1, Ackermann (num1, num2 - 1));
}