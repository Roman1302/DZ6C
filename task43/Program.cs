/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

void IntersectionStraight(double x1, double y1, double x2, double y2)
{
if (y1 - y2 == 0)
{
    Console.WriteLine();
    Console.WriteLine("Прямые совпадают");
}
else if (y1 / x1 == y2 / x2)
{
    Console.WriteLine();
    Console.WriteLine("Прямые параллельны");
}
else
    {
        double x = (x2 - x1) / (y1 - y2);
        double y = y1 * x + x1;
        Console.WriteLine();
        Console.WriteLine($"({x}; {y})");
    }
}

Console.Clear();
Console.WriteLine("Программа, рассета точки пересечения двух прямых");

Console.Write("Введите точку (b) отрезка 1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите точку (k) отрезка 1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите точку (b) отрезка 2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите точку (k) отрезка 2: ");
double k2 = double.Parse(Console.ReadLine()!);

IntersectionStraight(b1, k1, b2, k2);