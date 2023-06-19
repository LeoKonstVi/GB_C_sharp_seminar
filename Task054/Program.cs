// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// Функция упорядочивания по убыванию элементов каждой строки двумерного массива.

void DescendingOrderRowElements(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) // итератор строк
    {
        // пузырьковая сортировка по строке
        for (int k = arr.GetLength(1); k > 1; k--) // итератор для последнего элемента в строке
        {
            for (int j = 1; j < k; j++) // итератор по столбцам
            {
                if (arr[i, j] > arr[i, j - 1])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, j - 1];
                    arr[i, j - 1] = temp;
                }
            }
        }
    }
}

int[,] array = CreateMatrixRndInt(4, 5, 0, 9);
PrintMatrix(array);
Console.WriteLine();
DescendingOrderRowElements(array);
PrintMatrix(array);