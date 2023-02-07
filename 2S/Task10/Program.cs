/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int GetNumber()
{
    Console.WriteLine("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int TwoNumber()
{
    int number = GetNumber();
    number = (number % 100) / 10;
    return number;
}

int number2 = TwoNumber();

Console.WriteLine(number2);
