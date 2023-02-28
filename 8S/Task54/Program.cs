/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int[,] ArrayOrdered(int[,] matrix)
{
    int rowsIndex;
    int number;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowsIndex = j;

            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, rowsIndex]) 
                rowsIndex = k;
            }

            number = matrix[i, j];
            matrix[i, j] = matrix[i, rowsIndex];
            matrix[i, rowsIndex] = number;
        }
    }
    return matrix;
}

int countRows = GetNumber("Введите кол-во строк:");
int countColumns = GetNumber("Введите кол-во столбцов:");
int[,] matrix = InitMatrix(countRows, countColumns);

PrintMatrix(matrix);

int[,] matrix2 = ArrayOrdered(matrix);
PrintMatrix(matrix2);