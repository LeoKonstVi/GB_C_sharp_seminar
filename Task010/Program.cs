// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigitThreeDigitNumber(int num)
{
        return num / 10 % 10;
}

Console.WriteLine("Введите целое положительное трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (100 <= number && number <= 999)
{
    Console.WriteLine("Вторая цифра трехзначного числа:");
    Console.WriteLine(SecondDigitThreeDigitNumber(number));
}
else
{
    Console.WriteLine("Введено неверное число");
}

