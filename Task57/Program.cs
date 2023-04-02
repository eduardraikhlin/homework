// 57. Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] array2d = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array2d);
int[] array = TransformMatrixToArray(array2d);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);
Console.WriteLine();
PrintFrequencyDictionary(array);


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
            Console.Write($"{matrix[i, j], 4} ");
        } 
    Console.WriteLine("|");
    }
}

void PrintArray(int[] arr)
{
Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    } 
    Console.Write("]");
}

int[] TransformMatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[index] = matrix [i, j];
            index++;
        }
    } 
    return array;
}

void SortArray (int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < arr.Length; j++)       
        {
            if (arr[j] < arr[minPosition]) 
            {
                minPosition = j;
            }
        }
        int temp = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temp;

    }
}

void PrintFrequencyDictionary (int[] arr)
{
    int count = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.WriteLine($"количество {arr[i]} в массиве равно {count}");
            break;
        }
        if (arr[i] == arr[i + 1]) count++;
        else 
        {
            Console.WriteLine($"количество {arr[i]} в массиве равно {count}");
            count = 1;
        }
    }
}