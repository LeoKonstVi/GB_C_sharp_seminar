// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine();
    }
}

// Функция суммирования элементов в каждой строке. Результат выдаётся одномерным массивом.
int[] SumRowElements(int[,] arr)
{
    int[] sumRowElements = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumRowElements[i] += arr[i, j];
        }
    }
    return sumRowElements;
}

// Функция поиска индекса минимального элемента в одномерном массиве.

int IndexMinElemetArray(int[] arr)
{
    int min = arr[0];
    int indexMinElement = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            indexMinElement = i;
        }
    }
    return indexMinElement;
}

// Функция печати массива с суммами элементов
void PrintArray(int[] arr)
{
    Console.WriteLine("Строка | Cумма");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{i + 1, 6} | {arr[i], 5}");
    }
}

int[,] matrix = CreateMatrixRndInt(5, 4, 0, 9);
int[] sumRowElements = SumRowElements(matrix);
int indexMinElement = IndexMinElemetArray(sumRowElements);

Console.WriteLine("Двумерный массив:");
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Сумма элементов массива по строкам:");
PrintArray(sumRowElements);
Console.WriteLine();
Console.WriteLine($"Минимальная сумма элементов в строке - {indexMinElement + 1}");