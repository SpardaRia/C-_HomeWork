/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int GetNumber(string messege)
{
    Console.WriteLine(messege);
    int resultNumber = 0;
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out resultNumber))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введены некоректные данные. Повторите попытку.");
        }
    }

    return resultNumber;
}


void PointIntersectionStraights(double b1, double b2, double k1, double k2)
{
    double x = (b2-b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения прямых: ({x}) и ({y})");
}


double b1 = GetNumber("Введите b1");
double k1 = GetNumber("Введите k1");
double b2 = GetNumber("Введите b2");
double k2 = GetNumber("Введите k2");
Console.WriteLine();
PointIntersectionStraights(b1, b2, k1, k2);