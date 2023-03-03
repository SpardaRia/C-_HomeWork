/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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

int FunctionAkerman(int num1, int num2)
{
    if(num1 == 0)
    {
        return num2 + 1;
    }
    else if (num2 == 0)
    {
        return FunctionAkerman(num1 - 1, 1);
    }
    else
    {
        return FunctionAkerman(num1 - 1, FunctionAkerman(num1, num2 - 1));
    }
}

int userNumber1 = GetNumber("Введите первое число: ");
int userNumber2 = GetNumber("Введите второе число: ");

int AkermanNumber = FunctionAkerman(userNumber1, userNumber2);
Console.WriteLine();
Console.WriteLine($"A({userNumber1},{userNumber2}) = {AkermanNumber}");
