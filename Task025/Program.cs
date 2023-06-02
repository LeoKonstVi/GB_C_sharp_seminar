// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Функция возведения в натуральную степень

int Power(int number, int power)
{
    int result = 1;
    for (int i = 1; i <= power; i++)
    {
          result *= number;
    }
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int power = Convert.ToInt32(Console.ReadLine());

Int64 numberPower = Power(number, power);

Console.WriteLine($"Число {number} в степени {power} равно: {numberPower}");