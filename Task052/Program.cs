// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] MeanColumnsMatrix(int[,] matrix)
{
    double[] meanColumns = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j]; 
        }
        meanColumns[j] = Convert.ToDouble(sum) / Convert.ToDouble(matrix.GetLength(0));
    }
    return meanColumns;
}

void PrintArray (double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{Math.Round(array[i], 1), 6}");
    }
    Console.Write($"{Math.Round(array[array.Length - 1], 1), 6}");
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 9);
double[] meanColumns = MeanColumnsMatrix(array2D);

Console.WriteLine("Двумерный массив целых чисел:");
PrintMatrix(array2D);
Console.WriteLine("Средние значения по столбцам:");
PrintArray(meanColumns);