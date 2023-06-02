// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Функция суммы цифр числа

int SumDigitOfNumber(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum =  SumDigitOfNumber(number);

Console.Write($"Сумма цифр числа {number} равна {sum}");
