// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int RequestNumberInt(string text)
{
    Console.Write(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размеры двумерного массива");
int n = RequestNumberInt("Введите количество строк: ");
int m = RequestNumberInt("Введите количество столбцов: ");
int[,] spiral = new int[n, m]; // двумерный массив размером n x m
int k = 1; // итератор чисел заполнения массива (от 1 до n * m)
int l = 0; // итератор сдвига заполняемых строк и столбцов
int i = 0, j = 0; // i - итератор по строкам, j - итератор по столбцам
while (k <= n * m)
{
    spiral[i, j] = k;
    if (i == l && j < m - l - 1) // условие заполнения верхней строки
    {
        j++;
    }
    else 
    {
        if (j == m - l - 1 && i < n - l - 1) // условие заполнения правого крайнего столбца
        {
            i++;
        }
        else
        {
            if (i == n - l - 1 && j > l ) // условие заполнения нижней строки
            {
                j--;
            }
            else
            {
                if (j == l && i > l + 1) // условие заполнения левого крайнего столбца до препоследнего элемента
                i--;
            }
        }
    }
    if (i == l + 1 && j == l) // условие увеличения итератора сдвига
    {
        l++;
    }
    k++;
}
Console.WriteLine();
Console.WriteLine("Матрица заполненная по спирали");
Console.WriteLine();
PrintMatrix(spiral);
Console.WriteLine();
