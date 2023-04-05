// 58. Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] firstMatrix = CreateMatrixRndInt(4, 2, 1, 9);
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = CreateMatrixRndInt(2, 3, 1, 9);
PrintMatrix(secondMatrix);
Console.WriteLine();

if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    int[,] matrixMulti = MatrixMultiplication(firstMatrix, secondMatrix);
    PrintMatrix(matrixMulti);
}
else 
{
    Console.WriteLine("Исходные матрицы невозможно перемножить");
}

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

int[,] MatrixMultiplication(int[,] firstArray2d, int[,] secondArray2d)
{
    int[,] multiMatrix = new int[firstArray2d.GetLength(0), secondArray2d.GetLength(1)];
    for (int i = 0; i < firstArray2d.GetLength(0); i++)
    {
        int m = 0;
        int indexRow = i;
        int indexColumn = 0;
        while (m < secondArray2d.GetLength(1))
        {
            int k = 0;
            int sum = 0;
            for (int j = 0; j < firstArray2d.GetLength(1); j++)
            {
                sum += firstArray2d[i, j] * secondArray2d[k, m];
                k++;
            }
            multiMatrix[indexRow, indexColumn] = sum;
            indexColumn++;
            m = indexColumn;
        }
    }
    return multiMatrix;
}