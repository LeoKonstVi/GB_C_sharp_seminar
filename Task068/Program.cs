// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int EnterNumber(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция Аккермана
int Ack(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if (m == 0)
        {
        return Ack(n - 1, 1);
        }
    }
    return Ack(n - 1, Ack(n, m -1));
}

Console.WriteLine();
Console.WriteLine("Введите аргументы функции Аккермана Ack(m, n). Аргументы m, n неотрицательные целые числа.");
int m = EnterNumber("Введите аргумент m: ");
if (m < 0)
{
    Console.WriteLine();
    Console.WriteLine("Введено ненатуральное число!");
    Console.WriteLine();
    return;
}
int n = EnterNumber("Введите аргумент n: ");
if (n < 0)
{
    Console.WriteLine();
    Console.WriteLine("Введено ненатуральное число!");
    Console.WriteLine();
    return;
}

int ack = Ack(m, n);

Console.WriteLine();
Console.WriteLine($"Значение функции Аккермана Ack({m}, {n}) = {ack}");
Console.WriteLine();