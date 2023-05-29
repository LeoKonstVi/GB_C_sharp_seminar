// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt16(Console.ReadLine());

int i = 1;
while (i <= n)
{
    Console.WriteLine($"{i, 3} | {Math.Pow(i, 3), 9}");
    i++;
}
