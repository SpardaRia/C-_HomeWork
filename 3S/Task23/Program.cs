/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber()
{
    Console.WriteLine("Введите число: ");
    int number = 0;
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out number))
        {
            break;
        }
    
    else
        {
           Console.WriteLine("Введено не число. Посторито ввод: ");
        }
    }
    return number;
}

void CubeNumbers(int number)
{
    int i = 1;
    while(i <= number)
    {
        int cube = i * i * i;
        Console.Write($" {cube},");
        i++;
    }
}

int UserNumber = GetNumber();
CubeNumbers(UserNumber);