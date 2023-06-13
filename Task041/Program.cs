// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Заполнение пользователем массива целыми числами
void FillArrayByUser (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

// Подсчет количества положительных чисел >0 в массиве
int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

Console.Write("Введите количество чисел, котороу будете вводить: ");
int QuantityNumbers = Convert.ToInt32(Console.ReadLine());

int[] arrayUser = new int[QuantityNumbers];
FillArrayByUser(arrayUser);
int countPositiveNumbers = CountPositiveNumbers(arrayUser);

Console.WriteLine("Введенный массив");
PrintArray(arrayUser);
Console.Write($"Количество положительных чисел в массиве: {countPositiveNumbers}");

