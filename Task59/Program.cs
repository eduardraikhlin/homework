// 59. Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

int[,] array2d = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array2d);
int[] array = CoordinatesMinimumValue(array2d);
int[,] newArray2d = DropColumnAndRow(array[0], array[1], array2d);
Console.WriteLine();
PrintMatrix(newArray2d);

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

int[] CoordinatesMinimumValue(int[,] matrix)
{
    int minIndexRow = 0;
    int minIndexColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minIndexRow, minIndexColumn])
            {
                minIndexRow = i;
                minIndexColumn = j;
            }
        }
    }
    return new int[] { minIndexRow, minIndexColumn };
}

int[,] DropColumnAndRow(int minI, int minJ, int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] newMatrix = new int[rows - 1, columns - 1];

    for (int i = 0, newRow = 0; i < rows; i++)
    {
        if (i == minI)
        {
            continue;
        }

        for (int j = 0, newColumn = 0; j < columns; j++)
        {
            if (j == minJ)
            {
                continue;
            }

            newMatrix[newRow, newColumn] = matrix[i, j];
            newColumn++;
        }
        newRow++;
    }
    return newMatrix;
}
