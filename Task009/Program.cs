// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

// Определение какая цифра двухзначного числа больше

if(firstDigit > secondDigit) 
    Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
else
    Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// Определение какая цифра двухзначного числа больше с помощью тернарного оператора

int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

// int MaxDigit (int num)
// {

// }