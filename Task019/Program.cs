// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// 

// Функция разворота числа

int NumInverse (int num)
{
    int numInverse = 0;
    int numWithoutDigit = num;
    while (numWithoutDigit != 0)
    {
        numInverse = numInverse * 10 + numWithoutDigit % 10;
        numWithoutDigit = numWithoutDigit / 10;
    }
    return numInverse;
}

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number == NumInverse(number))
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}   
    
