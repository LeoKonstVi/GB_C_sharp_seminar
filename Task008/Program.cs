// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("До числа 1 нет чётных чисел");
}
else
{
int i = 2;
    do
    {
        Console.Write($"{i} ");
        i = i + 2;
    }
    while (i <= number);
}