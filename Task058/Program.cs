// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int RequestData(string text)
{
    Console.Write(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationMatrixs(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}

Console.WriteLine();
Console.WriteLine("Введите количество строк и столбцов первой матрицы: ");
int rows = RequestData("Количество строк: ");
int columns = RequestData("Количество столбцов: ");
int[,] userMatrix1 = CreateMatrixRndInt(rows, columns, 0, 9);

Console.WriteLine("Введите количество строк и столбцов второй матрицы: ");
rows = RequestData("Количество строк: ");
columns = RequestData("Количество столбцов: ");
int[,] userMatrix2 = CreateMatrixRndInt(rows, columns, 0, 9);
Console.WriteLine();

if (userMatrix1.GetLength(1) != userMatrix2.GetLength(0)) 
{
    Console.WriteLine("Количество столбцов первой матрицы, не совпадает с количеством строк второй матрицы.");
    Console.WriteLine("Такие матрицы умножить друг на друга нельзя.");
    Console.WriteLine();
    return;
}


int[,] multiplicationMatrix = MultiplicationMatrixs(userMatrix1, userMatrix2);

Console.WriteLine("Первая матрица:");
PrintMatrix(userMatrix1);
Console.WriteLine("Вторая матрица:");
PrintMatrix(userMatrix2);
Console.WriteLine("Результат умножения первой матрицы на вторую:");
PrintMatrix(multiplicationMatrix);
Console.WriteLine();