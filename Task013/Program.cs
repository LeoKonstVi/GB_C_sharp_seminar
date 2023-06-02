// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Функция получения третьей цифры трехзначного числа

int ThirdDigitThreeDigitNumber(int num)
{
    return num % 10;
}

// Ввод данных целое число

Console.WriteLine("Введите целое число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (0 <= number && number <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    Console.WriteLine("Третья цифра числа:");
    Console.WriteLine(ThirdDigitThreeDigitNumber(number));
}