// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

// Функция создания 3-х мерного массива заполненного неповторяющимися двузначными числами.
int[,,] CreateArray3dTwoDigitNumbers(int size1, int size2, int size3)
{
    int number = 10; // переменная двузначных чисел
    int[,,] array3d = new int[size1, size2, size3];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size3; k++)
            {
                array3d[i, j, k] = number;
                number++;
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

int[,,] userArray3d = CreateArray3dTwoDigitNumbers(4, 3, 3);
Console.WriteLine();
PrintArray3d(userArray3d);
Console.WriteLine();