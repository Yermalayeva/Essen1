// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*int[] numbers = CreateRandomArray(5, 100, 1000);
PrintArray(numbers, "Random Numbers");

int sum = GetSumChetnNumbers(numbers);
int GetSumChetnNumbers(int[] numbers)
{
    int count = 0;
    for (var z = 0; z < numbers.Length; z++)
    {
        if(numbers[z] % 2 == 0)
        count++;
    }
    return count;
}
Console.WriteLine("Четных "+ sum);

int [] CreateRandomArray(int size, int min, int max)
{
    Random random = new Random();
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
    return numbers;
}


void PrintArray(int[] numbers, string message)
{
    string str = string.Join(", ", numbers);
    Console.WriteLine($"{message} - [ {str} ]");
}*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*int[] array = CreateRandomArray(5, -10, 10);
PrintArray(array, "Random Numbers");

int sum = GetSumNumbers(array);
int GetSumNumbers(int[] array)
{
    int number = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            number += array[i];
        }
    }
    return number;
}
Console.WriteLine("Сумма равна: "+ sum);

int [] CreateRandomArray(int size, int min, int max)
{
    Random random = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}


void PrintArray(int[] array, string message)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"{message} - [ {str} ]");
}*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Например: [3 7 22 2 78] -> 76.

int[] array = CreateRandomArray(5);
PrintArray(array, "Random Array");
int max = array[0];
int min = array[0];
int difference= GetDifferenceNumberInArray(array);
int GetDifferenceNumberInArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            {
                max = array[i];
            }
        if (array[i] < min)
            {
                min = array[i];
            }
    }
    return (max - min);
}

Console.WriteLine("Разница  "+ difference);

int [] CreateRandomArray(int size)
{
    Random random = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 200);
    }
    return array;
}


void PrintArray(int[] array, string message)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"{message} - [ {str} ]");
}