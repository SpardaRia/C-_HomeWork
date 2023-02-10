/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int UserNumber(string message)
{
    Console.WriteLine(message);
    int getNumber = 0;
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out getNumber) && getNumber > 9999 && getNumber < 100000)
        {
                break;
        }        
        else
        {
        
            Console.WriteLine("Ввели неверное число или не число. Повторите ввод!");
        
        }
    }
    return getNumber;
}

void PalindromeNumber(int user)
{
    if(user / 10000 == user % 10)
    {
         Console.WriteLine($"Число {user} палидром");
    }
    else
    {
        Console.WriteLine($"Число {user} не палидром");
    }
}

int number = UserNumber("Введите пятизначное число: ");
PalindromeNumber(number);
