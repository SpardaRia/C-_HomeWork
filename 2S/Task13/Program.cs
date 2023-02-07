/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


int GetNumber()
{
    Console.WriteLine("Введите число: ");
    int userNumber1 = Convert.ToInt32(Console.ReadLine());
    return userNumber1;
}

void ThirdDigit(int x)
{
    if (x > 99)
    {
        Console.Write("Третья цифра в числе: ");
        Console.Write(Convert.ToString(x)[2]);
    }
    else
    Console.WriteLine("Третьей цыфры нет");
    }

int userNumber = GetNumber();
ThirdDigit(userNumber);
