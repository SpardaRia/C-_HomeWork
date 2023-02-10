/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int GetNumber(string messege)
{
    int resultNumber = 0;
    Console.WriteLine(messege);

    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Введены некоректные данные. Повторите попытку.");
            Console.WriteLine();
        }
    }
    Console.Write("Массив: ");

    return  Math.Abs(resultNumber);
}


int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    Console.WriteLine(string.Join(", ", arr));
    return arr;
}

void PositiveNumber(int [] mas)
{
    int chot = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if(mas[i] % 2 == 0)
        {
            chot += 1;
        }
    }
    Console.WriteLine($"В массиве колличесво четных чисел = {chot}");
} 

int userNumber = GetNumber("Введите длинну массива: ");
int[] array = InitArray(userNumber);
PositiveNumber(array);


