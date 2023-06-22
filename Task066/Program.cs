// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int RequestNumberInt(string text)
{
    Console.Write(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumNaturalNumberMN(int m, int n)
{
    if (m == n) return n;
    return m + SumNaturalNumberMN(m + 1, n);
}
   
Console.WriteLine();
Console.WriteLine("Введите два натуральных числа.");
int m = RequestNumberInt("Введите первое натуральное число: ");
if (m <= 0)
{
    Console.WriteLine();
    Console.WriteLine("Введено ненатуральное число!");
    Console.WriteLine();
    return;
}
int n = RequestNumberInt("Введите второе натуральное число: ");
if (n <= 0)
{
    Console.WriteLine();
    Console.WriteLine("Введено ненатуральное число!");
    Console.WriteLine();
    return;
}

int sumNaturalNumber = 0;
if (m < n)
{
    sumNaturalNumber = SumNaturalNumberMN(m, n);
}
else
{
    sumNaturalNumber = SumNaturalNumberMN(n, m);
}

Console.WriteLine();
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {sumNaturalNumber}");
Console.WriteLine();