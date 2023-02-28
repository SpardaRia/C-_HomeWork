/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
Console.WriteLine();
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

int SmallerAmountRow(int[,] matrix)
{
    int minRow = 0, minSum = 0, sum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (i == 0 || sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    return (minRow+1);
}

int countRows = GetNumber("Введите кол-во строк:");
int countColumns = GetNumber("Введите кол-во столбцов:");
int[,] matrix = InitMatrix(countRows, countColumns);

PrintMatrix(matrix);

Console.WriteLine($"Наименьшая сумма элементов в строке {SmallerAmountRow(matrix)}");
