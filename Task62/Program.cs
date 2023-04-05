// 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array2d = CreateMatrixSpiral(4, 4, 1, 16);
PrintMatrix(array2d);

int[,] CreateMatrixSpiral(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                matrix[i, j] = min;
                min++;
            }
            else if (i == 1 && j == 3)
            {
                matrix[i, j] = min;
                min++;
            }
            else if (i == 2 && j == 3)
            {
                matrix[i, j] = min;
                min++;
            }
            else if (i == 3 && j == 3)
            {
                matrix[i, j] = min;
                min++;
            }
        }
    }
    for (int i = 3; i > 0; i--)
    {
        for (int j = 2; j >= 0; j--)
        {
            if (i == 3)
            {
                matrix[i, j] = min;
                min++;
            }
            else if (i == 2 && j == 0)
            {
                matrix[i, j] = min;
                min++;
            }
            else if (i == 1 && j == 0)
            {
                matrix[i, j] = min;
                min++;
            }
        }
    }
    for (int i = 1; i < 3; i++)
    {
        for (int j = 1; j < 3; j++)
        {
            if (i == 1)
            {
                matrix[i, j] = min;
                min++;
            }
            else if (i == 2 && j == 1)
            {
                matrix[i, j] = min + 1;
            }
            else if (i == 2 && j == 2)
            {
                matrix[i, j] = min;
            }
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