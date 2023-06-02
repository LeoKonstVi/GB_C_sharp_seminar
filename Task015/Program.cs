// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели (число от 1 до 7):");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if ( 1 <= dayWeek && dayWeek <= 7 )
{
    if (dayWeek == 6 || dayWeek == 7)
    {
    Console.WriteLine("Это выходной день");
    }
    else
    {
    Console.WriteLine("Это рабочий день");    
    }
}
else
{
    Console.WriteLine("Неверный ввод");
}