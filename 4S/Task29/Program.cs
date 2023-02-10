/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] CreatArray()
{
    int[] Array = new int[8];
    Random number = new Random();

    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = number.Next(1, 100);
    }
    return Array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    Console.Write(string.Join(", ", array));
    Console.Write("]");
}

int[] Array = CreatArray();
PrintArray(Array);
