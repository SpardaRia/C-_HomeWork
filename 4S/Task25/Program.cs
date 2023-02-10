/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = 0;
    while(true)
    {
       
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
             Console.WriteLine("Некоректный ввод данный. Посторите ввод: ");
        }
    }
    return result;    
}

void DegreeNumber(int number1, int number2)
{
    double degree = Math.Pow(number1, number2);
    Console.WriteLine($"{number1} в степени {number2} равно {degree}");
}

int userNumber1 = GetNumber("Введите первое число");
int userNumber2 = GetNumber("Введите второе число");

DegreeNumber(userNumber1, userNumber2);