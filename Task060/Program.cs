// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

int RequestNumberInt(string text)
{
    Console.Write(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

// Функция создания 3-х мерного массива заполненного неповторяющимися двузначными числами.
int[,,] CreateArray3dTwoDigitNumbers(int size1, int size2, int size3)
{
    int[,,] array3d = new int[size1, size2, size3];
    int twoDigitNumber = 10; // переменная двузначных чисел
    
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size3; k++)
            {
                array3d[i, j, k] = twoDigitNumber;
                twoDigitNumber++;
            }
        }
    }
    return array3d;
}

void PrintArray3d(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
               Console.Write($"{array3d[i, j, k]}({i},{j},{k}) ");
            }
            Console.Write(" |  ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размеры 3-х мерного массива для заполнения двузначными числами");
int size1 = RequestNumberInt("Введите размер один: ");
int size2 = RequestNumberInt("Введите размер два: ");
int size3 = RequestNumberInt("Введите размер три: ");
int length = size1 * size2 * size3;
if (length > 90)
    {
        Console.WriteLine($"Размер массива {length} превышает 90 количество двузначных чисел");
        return;
    }

int[,,] userArray3d = CreateArray3dTwoDigitNumbers(size1, size2, size3);
Console.WriteLine();
PrintArray3d(userArray3d);
Console.WriteLine();