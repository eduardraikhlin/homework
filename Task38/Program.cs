// 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble (5, 1, 50);
PrintArray(array);
Console.WriteLine();
double minNumber = SearchMinNumber(array);
double maxNumber = SearchMaxNumber(array);
double diffMaxMin = DiffMaxMin(maxNumber, minNumber);
double result = Math.Round(diffMaxMin, 1);
Console.WriteLine($"Разница между max-элементом и min-элементом равна {result}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
         double num = rnd.NextDouble() * (max - min) + min;
         arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArray (double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]} . ");
        else Console.Write($"{arr[i]}");
    } 
    Console.Write("]");
}

double SearchMinNumber (double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
       if (arr[i] < min)
        {
            min = arr[i];
        } 
    }
    return min;
}

double SearchMaxNumber (double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
       if (arr[i] > max)
        {
            max = arr[i];
        } 
    }
    return max;
}

double DiffMaxMin (double max, double min)
{
    return max - min;
}