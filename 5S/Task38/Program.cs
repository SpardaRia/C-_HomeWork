/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
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

double[] IntArray (int dimension)
{
    double[] array = new double[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 100, 2);
    }
    Console.WriteLine(string.Join(" | ", array));
    return array;
}

void Difference(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];            
        }
        if(arr[i] < min)
        {
            min = arr[i];
        }
    }
    Console.WriteLine($"Разница между минимальным и максимальным значением массива ровна {Math.Round((max - min), 2)}");
}

int userNumber = GetNumber("Укажите длинну массива");
double[] arry = IntArray(userNumber);
Difference(arry);

