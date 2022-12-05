// // Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int num1= int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if((num1 % num2) != 0)
{
    int result = num1 % num2;
    Console.WriteLine("не кратно, остаток " + result);
}
else
{
    Console.WriteLine("кратно");
}