﻿//чтение массива данных
 string[] M;
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
M = stroka.Split(' ');
var result = new string[M .Length];
var realSize = 0;
//выборка по критерию
foreach (var value in M )
    {
        if (value.Length <= 3)
        {
        result[realSize] = value;
        realSize++;
        }
    }
//вывод результата
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
Console.ReadKey(true);