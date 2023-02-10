/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetCoordFromUser(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            {
                Console.WriteLine("Ввели некоректные данные");
            }
        }
    }
    return result;
}

double GetDistance(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
    return result;
}

int ax = GetCoordFromUser("Введи координаду X первой точки");
int ay = GetCoordFromUser("Введи координаду Y первой точки");
int az = GetCoordFromUser("Введи координаду Z первой точки");

int bx = GetCoordFromUser("Введи координаду X второй точки");
int by = GetCoordFromUser("Введи координаду Y второй точки");
int bz = GetCoordFromUser("Введи координаду Z второй точки");

double distant = GetDistance(ax, ay, az, bx, by, bz);

Console.WriteLine($"Расстояние между точками равно {Math.Round(distant, 2)}");