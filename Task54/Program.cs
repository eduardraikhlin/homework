// 54. Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:       В итоге получается вот такой массив:
// 1 4 7 2                       7 4 2 1
// 5 9 2 3                       9 5 3 2
// 8 4 2 4                       8 4 4 2

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 16);
PrintMatrix(array2d);
Console.WriteLine();
SortedRowsMaxToMin(array2d);
PrintMatrix(array2d);

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

void SortedRowsMaxToMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int currentColumn = 0;
        int maxPositionColumn = 0;
        while (currentColumn != matrix.GetLength(1)-1)
        {
            for (int j = currentColumn; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j + 1] > matrix[i, maxPositionColumn])
                {
                    maxPositionColumn = j + 1;
                }
            }
            int temp = matrix[i, currentColumn];
            matrix[i, currentColumn] = matrix[i, maxPositionColumn];
            matrix[i, maxPositionColumn] = temp;
            currentColumn++;
            maxPositionColumn = currentColumn;
        }
    }
}
