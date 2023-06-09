// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

int Input (string messege)
{
    Console.Write(messege);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);

Console.WriteLine("Двумерный массив:");
PrintMatrix(array2D);
Console.WriteLine("Для получения элемента массива");
int row = Input("Введите номер строки: ");
int column = Input("Введите номер столбца: ");

if (row < array2D.GetLength(0) && column < array2D.GetLength(1))
{
    Console.WriteLine($"Элемент [{row}, {column}] равен: {array2D[row, column]}");
}
else
{
    Console.WriteLine($"Элемента [{row}, {column}] в массиве нет!");
}