/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
вводим через один Enter (разбиваем через Split())
*/


Console.WriteLine("Введдите числа через пробел: ");
    string s = Console.ReadLine();
    Console.WriteLine();
  
    int count = 0;
    string[] str =  s.Split(' ');
   
       for (int i = 0; i < str.Length; i++)
    {
        if(Convert.ToInt32(str[i]) > 0)
        {
            count++;
        }
    }
   
Console.WriteLine(count);