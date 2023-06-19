// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalNumber(int n)
{
    if (n == 1)
    {
        Console.Write(1);
        return;
    }
    Console.Write($"{n}, ");
    NaturalNumber(n - 1);
}


Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Введено ненатуральное число!");
    return;
}
Console.WriteLine();
Console.WriteLine("Натуральные числа:");
NaturalNumber(number);
Console.WriteLine();
Console.WriteLine();