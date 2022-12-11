// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Например: 3, 5 -> 243 (3⁵); 2, 4 -> 16.

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());

double result = GetOneNumberStepToNumber(a, b);
Console.WriteLine(result);

double GetOneNumberStepToNumber(int a, int b)
{
    double result = 1;
    if (b == 0)
    {
        result = 1;
    }

    if (b > 0)
    {
        for (int i = 0; i < b; i++)
        {
            result = result * a;
        }
    }

    if (b < 0)
    {
        for (int i = 0; i > b; i--)
        {
            result = 1.0 / a * result;
        }
    }

    return result;
}




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Например: 452 -> 11; 82 -> 10; 9012 -> 12.

/*Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int result = GetSumNumber(number);

Console.WriteLine(result);

int GetSumNumber(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;

}*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Например: 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33].


/*Console.Write("Введите количество элементов массива: ");
int elementCount = int.Parse(Console.ReadLine());
int [] result = CreatArray();

int []CreatArray()
{
    int [] array = new int[elementCount];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

PrintArray(result);

void PrintArray(int [] array)
{
    Console.Write("[");
    for(var i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}*/