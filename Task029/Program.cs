// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Функция запрос элементов массива
void RequestArrayElement (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    
}

// Функция печать элементов массива в строку
void PrintArrayElements(int[] array)
{
    Console.Write("Элементы массива: ");
    Console.Write($"[{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.Write("]");
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arrayUser = new int[n];
RequestArrayElement(arrayUser);
PrintArrayElements(arrayUser);