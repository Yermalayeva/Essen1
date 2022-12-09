// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Например: 456 -> 3 78 -> 2 89126 ->5

/*Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int result = GetLengthNumber(number);

Console.WriteLine(result);

int GetLengthNumber(int number)
{
int count = 0;
while (number != 0)
{
    number = number / 10;
    count++;
}
return count;
}*/

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// Например: 4->24 5->120

/*Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
double p = GetProizvedenieNumbersBetweenOneTo(a);
Console.WriteLine(p);

double GetProizvedenieNumbersBetweenOneTo(int a)
{
    double p = 1;
    for(var i = 1; i <= a; i++)
    {
        p = p * i;
    }

    return p;
}*/

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// Например:[1,0,1,1,0,1,0,0]

int [] result = CreatArray();
PrintArray(result);

int []CreatArray()
{
    Random random = new Random();
    int [] array = new int [8];
    for(int i = 0; i < array.Length; i++)
    {
        array [i] = random.Next(0, 2);
    }
    return array;
}
void PrintArray(int [] array)
{
    Console.Write("[");
    for(var i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}
