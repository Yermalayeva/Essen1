//Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]
// int a = 5;
// int b = 6;
// int tmp = a;
// a = b;
// b = tmp;
/*int[] array = new int[5] { 1, 2, 3, 4, 5 };

int[] tmp = new int[array.Length];
Array.Copy(array, tmp, array.Length);
Reverse(array);
PrintArray(array);

PrintArray(tmp);

int[] reversed = Reverse2(array);
PrintArray(reversed);

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}

void Reverse(int[] array)
{  
    int tmp;
    for (var i = 0; i < array.Length / 2; i++)
    {
        tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
}

int[] Reverse2(int[] array)
{  
    int[] reversed = new int[array.Length];

    for (var i = 0; i < array.Length; i++)
    {
        reversed[i] = array[array.Length - 1 - i];
    }

    return reversed;
}*/


//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать
//треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

/*int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

GetFalseorTrue(num1, num2, num3);
Console.WriteLine(GetFalseorTrue(num1, num2, num3));

bool GetFalseorTrue(int a, int b, int c)
{
    if(a < (b + c) & b < (a + c) & c < (b + a))
    {
        return true;
    }
        return false;
}*/

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
// Например: 45 -> 101101; 3 -> 11; 2 -> 10

/*int number = int.Parse(Console.ReadLine());

Console.WriteLine(Get2NumberIs10(number));
string Get2NumberIs10(int number)
{
    string text = "";
    for(int i = 0; 0 < number; i++)
    {
        text = number % 2 + text;
        number /= 2;
    }
    return text;
}*/

//Задача 44: Не используя рекурсию, выведите первые
//N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1
// Если N = 5 -> 0 1 1 2 3.Если N = 3 -> 0 1 1 /Если N = 7 -> 0 1 1 2 3 5 8

/*Console.WriteLine("Введите значение N: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(string.Join(",", GetNumberFibonachi(number)));

int[]GetNumberFibonachi(int number)
{
    int[]array = new int[number];
    if(number > 0) array[0] = 0;
    if(number > 1) array[1] = 1;

    for(int i = 2; i < array.Length; i++)
    {
        array[i] = (array[i-1]) + (array[i - 2]);
    }
    return array;
}*/


//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью
//поэлементного копирования.

/*Console.WriteLine("Введите количество элементов массива: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];
Console.WriteLine(string.Join(",",GetRandomNumber(array)));

Console.WriteLine(string.Join(",",GetArrayRevers(array)));
int[]GetArrayRevers(int[]array)
{
    int[]arrayCopy = new int[array.Length];
    for(int i = 0; i<array.Length; i++)
    {
        arrayCopy[i] = array[i];

    }
    return arrayCopy;
}
int[]GetRandomNumber(int[]array)
{
    Random random = new Random();
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = random.Next(1,15);
    }
    return array;
}*/