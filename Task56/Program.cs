// 56. Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array2d = CreateMatrixRndInt(5, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
int[] sumElementsEachRow = SumElementsEachRow(array2d);

int index = IndexMinRowSumElem(sumElementsEachRow);
Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {index} строка");


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[] SumElementsEachRow (int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        array[index] = sum;
        index++;
    } 
    return array;
}

int IndexMinRowSumElem (int[] array)
{
     int indexMinRowSumElem = 0;
     for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)       
        {
            if (array[j] < array[indexMinRowSumElem]) 
            {
                indexMinRowSumElem = j;
            }
        }
    } 
    return indexMinRowSumElem;
}