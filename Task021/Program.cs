// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Функция расчета расстояния между 2-мя точками в 3D пространстве
double Distance (double x1, double y1, double z1, 
                 double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2 - z1, 2));
    return(distance);
}

// Функция запроса введения координат
double EnterCoordinate(string text)
{
    Console.Write(text);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

Console.WriteLine("Введите координаты двух точек");
double x1 = EnterCoordinate("Введите координату X первой точки: ");
double y1 = EnterCoordinate("Введите координату Y первой точки: ");
double z1 = EnterCoordinate("Введите координату Z первой точки: ");
double x2 = EnterCoordinate("Введите координату X второй точки: ");
double y2 = EnterCoordinate("Введите координату Y второй точки: ");
double z2 = EnterCoordinate("Введите координату Z второй точки: ");

double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками равно: {Math.Round(distance, 2, MidpointRounding.ToZero)}");