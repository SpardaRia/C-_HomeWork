/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
            Console.WriteLine();
        }
    }
    return resultNumber;
}

int [] Array(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    Console.WriteLine("Массив:");
    Console.WriteLine(string.Join(",", arr));
    return arr;
}

void SumNumber(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if(i % 2 == 0)
        {
            sum += mas[i];
        }
    }
    Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях ровна {sum}");
}

int userNumber = GetNumber("Введите длинну массива: ");
int [] mas = Array(userNumber);
SumNumber(mas);