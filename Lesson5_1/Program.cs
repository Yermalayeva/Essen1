//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// Например: [-4, -8, 8, 2] -> [4, 8, -8, -2]

/*int[] array = new int[] {-4, -8, 8, 2};
Console.WriteLine(string.Join(",", ChangeArray(array)));

int[] ChangeArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] != 0)
        {
            array[i] = array[i] * -1;
        }
    }
    return array;
}*/

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет 
// 3; массив [6, 7, 19, 345, 3] -> да

/*int[] array = new int[] {6, 7, 19, 345, 3};
Console.WriteLine(SearcNumberInArray(12, array));
Console.WriteLine(string.Join(",", ChangeArray(array)));

int[] ChangeArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] != 0)
        {
            array[i] = array[i] * 1;
        }
    }
    return array;
}

string SearcNumberInArray(int number, int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        return "ДА";
    }
    return "НЕТ";
}*/

// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

/*int[] array = CreateRandomArray(5);
PrintArray(array, "Random Array");
int min = 10;
int max = 99;
int sum = SearchCountNumberInArray(array, min, max);
int SearchCountNumberInArray(int[]array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max)
        //if (array[i] > array[i-1])
        {
            count++;
        }
    }
    return count;
    
}
 Console.WriteLine("Количество  "+ sum);

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
}*/

//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int[] array = CreateRandomArray(6, -10, 10);
PrintArray(array, "Random Array");
PrintArray(GetPairsInArray(array), "новый массив ");

int[] GetPairsInArray(int[] array)
{
    int num = array.Length % 2;
    int[] mArray = new int[array.Length / 2 + num];
    for (int i = 0; i < array.Length / 2; i++)
    {
        mArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if(num != 0)
    {
        mArray[mArray.Length - 1] = array[array.Length / 2];
    }
    return mArray;

}

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
}