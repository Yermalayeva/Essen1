﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Например: 4 -> да; -3 -> нет; 7 -> нет

Console.WriteLine("введите число: ");
int num = int.Parse(Console.ReadLine());
int E = num % 2;

if(E == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}