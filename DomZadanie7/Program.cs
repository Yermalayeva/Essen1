// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

/*0,5  7   -2   -0,2
  1  -3,3   8   -9,9
  8   7,8 -7,1    9*/


/*try
{
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    double[,] array = Create2DArray(m,n);
    Print2DArray(array);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Print2DArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

double[,] Create2DArray(int m, int n)
{
    double[,] array = new double[m,n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = (double)random.Next(-100,100)/10;
        }
    }

    return array;
}

int ReadInt(string title)
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }
    
    throw new Exception("Введены не корректные символы");
}*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

/* 1 4 7 2
   5 9 2 3
   8 4 2 4

17 -> такого числа в массиве нет*/


/*try
{
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    int[,] array = Create2DArray(m,n);
    Print2DArray(array);
    int searchNumber = ReadInt("Ввведите искомую позицию элемента");
    FindElementArray(array, searchNumber);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m,n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1,10);
        }
    }

    return array;
}

int ReadInt(string title)
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }
    
    throw new Exception("Введены не корректные символы");
}


void FindElementArray(int[,] element, int searchNumber)
{
    bool find = false;
    for (var i = 0; i < element.GetLength(0); i++)
    {
        for (var j = 0; j < element.GetLength(1); j++)
        {
            if(element[i,j] == searchNumber)
            {
            Console.WriteLine("Введенная позиция элемента находится по координатам:  " + i + "." + j);
            find = true;
            }
        }
        
    }
    if(! find)
    {
        Console.WriteLine("Введенной позиции элемента в данном массиве не существует");
 
    }
}*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
/* 1 4 7 2
   5 9 2 3
   8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

try
{
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    int[,] array = Create2DArray(m,n);
    Print2DArray(array);
    double[] result = GetAverageSumNumbers(array);
    PrintAverageSumNumbers(result);
}
catch (Exception ex)
{
   Console.WriteLine(ex.Message);
}

double [] GetAverageSumNumbers(int[,] array)
{
    double [] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avarage = (avarage + array[i, j]);
        }
        avarage = avarage / array.GetLength(0);
        result [j] = avarage;
    }

    return result; 
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m,n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1,10);
        }
    }

    return array;
}

int ReadInt(string title)
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }
    
    throw new Exception("Введены не корректные символы");
}

void PrintAverageSumNumbers(double [] result)
{
    for (int j = 0; j < result.Length; j++)
    {
        Console.Write($"Cреднее арифметическое столбца {j} = {result[j]}; " , " ");
        Console.WriteLine();
    }
}







////////////////////////////////////////////////////////////
// Без метода
/*Console.WriteLine("введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
FillArrayRandomNumbers(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i, j]);
    }
    avarage = avarage / array.GetLength(0);
    Console.Write($"Cреднее арифметическое столбца {j} = {avarage } {";"}");
    Console.WriteLine();
}

Console.WriteLine();
PrintArray(array);


void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
         Console.WriteLine();
    }
}*/




