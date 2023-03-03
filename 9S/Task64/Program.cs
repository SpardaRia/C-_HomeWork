/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string messege)
{
    Console.WriteLine(messege);
    int resultNumber = 0;
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 0)
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

void SequenceNumber(int number)
{
    if(number > 0)
    {
        Console.Write($"{number}, ");
        number -= 1;
        SequenceNumber(number);
    }
}


int userNumber = GetNumber("Ведите число больше 0; ");
Console.WriteLine();
SequenceNumber(userNumber);