/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int [,] ProductOfNumbers(int [,] matrix1, int [,] matrix2)
{
    int [,] matrixNew = new int [matrix1.GetLength(0), matrix2.GetLength(1)];


    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            matrixNew[i, j] = 0;
            for (int k = 0; k < matrixNew.GetLength(1); k++)
            {
                matrixNew[i, j] += matrix1[i, k]* matrix2[k, j];
            } 
            
        }
    }

    return matrixNew;
}

int countRows1 = GetNumber("Введите кол-во строк массива 1:");
int countColumns1 = GetNumber("Введите кол-во столбцов массива 2:");

int countRows2 = GetNumber("Введите кол-во строк массива 2:");
int countColumns2 = GetNumber("Введите кол-во столбцов массива 2:");


Console.WriteLine("Массив 1:");
int[,] matrix1 = InitMatrix(countRows1, countColumns1);
PrintMatrix(matrix1);

Console.WriteLine("Массив 2:");
int[,] matrix2 = InitMatrix(countRows2, countColumns2);
PrintMatrix(matrix2);

if(matrix1 != matrix2)
{
    Console.WriteLine("Матрицы несовместимы");
}


int[,] matrixNew =  ProductOfNumbers(matrix1, matrix2);
PrintMatrix(matrixNew);


