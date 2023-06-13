// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// k1 = 5, b1 = 2,  k2 = 9, b2 = 4  -> (-0,5; -0,5)

// Функция запрос данных у пользователя

double DataRequest(string coefficient)
{
    Console.Write($"Введите коэффициент {coefficient}: ");
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

// Расчёт координат точки пересечения 2-х прямых.
double[] CoordinateIntersection(double k1, double b1, double k2, double b2)
{
    double[] coordinateIntersection = new double[2]; // массив для координат
    coordinateIntersection[0] = (b2 - b1) / (k1 - k2); // координата пересечения x
    coordinateIntersection[1] = (k1 * b2 - k2 * b1) / (k1 - k2); // координата пересечения y
    return coordinateIntersection;
}

Console.WriteLine("Введите коэффициенты k1, b1, k2, b2 уравнений y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine();
double k1 = DataRequest("k1");
double b1 = DataRequest("b1");
double k2 = DataRequest("k2");
double b2 = DataRequest("b2");
Console.WriteLine();

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны и не имеют точки пересечения");
}
else
{
    double[] coordinateIntersection = CoordinateIntersection(k1, b1, k2, b2);
    Console.WriteLine($"Координаты точки пересечения x = {coordinateIntersection[0]}, y = {coordinateIntersection[1]}");
}
