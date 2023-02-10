/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int retern = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out retern))
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорентный ввод. Повторите попытку");
        }
    }
    return Math.Abs(retern);
}

void SumNumber(int number)
{
    
    int sum = 0;
    string textNumber = number.ToString();
    
    for (int i = 0; i < textNumber.Length; i++)
    {
        sum += (textNumber[i]- '0');
    }

    Console.WriteLine();
    Console.Write($"Чумма цифр в числе: {sum}");
}

int usreNumber = GetNumber("Введите число: ");
SumNumber(usreNumber);
