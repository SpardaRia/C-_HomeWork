/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int GetNumber()
{
    Console.WriteLine("Введи число, соотвествующее дню недели: ");
    int uzerNumber = Convert.ToInt32(Console.ReadLine());
    return uzerNumber;
}

int uzerNumber = GetNumber();

if(uzerNumber > 0 && uzerNumber< 6)
{
    Console.WriteLine("День не является выходным");
}
else if(uzerNumber == 6 || uzerNumber == 7)
{ 
    Console.WriteLine("День является выходным");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}
