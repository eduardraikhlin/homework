﻿// 60. Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] array3d = CreateMatrix3d (3, 5, 6, 10);
   if (array3d.Length < 91)
  {
    PrintMatrix3d(array3d);
  }
  else
  {
      Console.WriteLine("Ошибка. Выход за двухзначный диапозон чисел!");
  }

int[,,] CreateMatrix3d(int rows, int columns, int depth, int min)
{
    int[,,] matrix = new int[rows, columns, depth];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           for (int k = 0; k < matrix.GetLength(2); k++)
           {
                matrix[i, j, k] = min;
                min++;
           }
        }
    }
    return matrix;
}

void PrintMatrix3d(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k], 4}({i},{j},{k})");
            }
        }
        Console.WriteLine("|");
    }
}