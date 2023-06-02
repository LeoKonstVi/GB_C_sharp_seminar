// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateFillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (length - i > 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int SumOddElementsArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+= 2)
    {
        sum+= array[i];
    }
    return sum;
}

int[] array = CreateFillArray(10, -10, 10);
int sumOddElementsArray = SumOddElementsArray(array);

Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine("Сумма нечётных элементов массива:");
Console.WriteLine(sumOddElementsArray);