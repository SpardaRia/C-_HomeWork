/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

void Sum(int number1, int number2)
{
    int sum = 0;
    for (int i = number1; i <= number2; i++)
    {
        sum += i;
    }
    Console.WriteLine($"Сумма чисел {sum}");
}

int numberOne = 0;
int number2 = 0;

while(true)
{
    bool qwert = false;
numberOne = GetNumber("Выедите первое число");
number2 = GetNumber("Ведите второе число больше первого");
if(numberOne < number2)
{
    qwert = true;
    break;
}
else
{
    Console.WriteLine("Введены некоретные числа. Повторите попытку");
}

}
Sum(numberOne, number2);