/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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

int[,] SnailMatrix(int RowsColumns)
{
    int[,] matrix = new int[RowsColumns, RowsColumns];
    int number = 1;

    for (int i = 0; i < (RowsColumns / 2 + RowsColumns % 2); i++)
    {
        // заполняем массив слева на право по одной строке

        for (int col = i; col < RowsColumns - i; col++)
        {
            matrix[i, col] = number++;
        }

        // заполняем массив снизу вверх по одному столбцу

        for (int row = i + 1; row < RowsColumns - i; row++)
        {
            matrix[row, RowsColumns - 1 - i] = number++;
        }

        // заполняем массив с права на лево по одной строке

        for (int col = RowsColumns - 2 - i; col >= i; col--)
        {
            matrix[RowsColumns - 1 - i, col] = number++;
        }

        // заплняем массим снизу вверх по одному столбцу

        for (int row = RowsColumns - 2 - i; row > i; row--)
        {
            matrix[row, i] = number++;
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:d2} ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

int count = GetNumber("Введите размер квадратного массива: ");

int [,] matrix = SnailMatrix(count);
PrintMatrix(matrix);