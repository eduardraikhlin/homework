// 41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите размерность массива: ");
int sizeNumber = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayInt(sizeNumber);
PrintArray(array);
int pozitiveElem = CountPositiveElements(array);
Console.WriteLine();
Console.WriteLine($"Количество положительных чисел, введенных пользователем равно {pozitiveElem}");

int[] CreateArrayInt(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите элемент массива c индексом {i}: ");
        int inumber = Convert.ToInt32(Console.ReadLine());
        arr [i] = inumber;
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    } 
    Console.Write("]");
}

int CountPositiveElements (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}