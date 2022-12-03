// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
// например: 2, 3, 7 -> 7; 44 5 78 -> 78; 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int num1= int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());

if(num1 > num1)
{
    if(num1 > num2)
    {
       int max = num1;
       Console.WriteLine(max); 
    }
    else
    {
        int max = num2;
        Console.WriteLine(max);
    }
}
else if(num2 > num3)
{
    int max = num2;
    Console.WriteLine(max);
}
else
{
    int max = num3;
    Console.WriteLine(max);
}