﻿// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine());
string result = GetDiapazon(number);
Console.WriteLine(result);

string GetDiapazon (int number)
{
    if(number == 1)
    {
        return ("x > 0 && y > 0");
    }

    if(number == 2)
    {
        return ("x > 0 && y < 0");
    }

    if(number == 3)
    {
        return ("x < 0 && y < 0");
    }

    if(number == 4)
    {
        return ("x < 0 && y > 0");
    }

    return ("-1");
}
