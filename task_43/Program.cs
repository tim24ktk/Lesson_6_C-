/*
    Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
    значения b1, k1, b2 и k2 задаются пользователем.
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double ReadData(string line)
{
    Console.WriteLine(line);
    double number = double.Parse(Console.ReadLine() ?? "");
    return number;
}

void FindIntersection(double b1, double k1, double b2, double k2)
{
    if (b2 != b1 && k1 != k2)
    {
        // k1 * x + b1 - (k2 * x + b2) = 0; k1 * x + b1 - k2 * x - b2 = 0; k1 * x - k2 * x = b2 - b1; x * (k1 -k2) = b2 -b1; x = (b2 - b1) / (k1 - k2)

        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Координаты точек пересечения 2-х прямых ({x}, {y})");
    }
    else
    {
        Console.WriteLine($"У прямых нет точек пересечения! Они либо параллельны, либо совпадают!");
    }
}

double b1 = ReadData("Введите значение b1: ");
double k1 = ReadData("Введите значение k1: ");
double b2 = ReadData("Введите значение b2: ");
double k2 = ReadData("Введите значение k2: ");

FindIntersection(b1, k1, b2, k2);