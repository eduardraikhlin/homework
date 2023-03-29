// 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);

Console.Write("Введите номер строки позиции элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца позиции элемента: ");
int column = Convert.ToInt32(Console.ReadLine());

if (row < 0 || column < 0)
{
    Console.WriteLine("Ошибка.Введено некорректное значение");
}
else
{
bool result = CheckDimension(array2d, row, column);
Console.WriteLine(result ? $"Значение элемента на заданной позиции равно {array2d[row, column]}"
                         : $"Такого элемента в массиве нет");
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

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4} ");
        } 
    Console.WriteLine("|");
    }
}

bool CheckDimension (int[,] matrix, int iRow, int jColumn)
{
    return iRow < matrix.GetLength(0) && jColumn < matrix.GetLength(1);
}