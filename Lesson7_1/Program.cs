// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Ai,j = i+j. Выведите полученный массив на экран.
//m = 3, n = 4.
/* 0 1 2 3
// 1 2 3 4
   2 3 4 5*/

/*try
{
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    int[,] array = Create2DArray(m,n);
    Print2DArray(array);
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

    ///Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j ;
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






// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса нечетные, и замените эти элементы на их
// квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

try
{
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    int[,] array = Create2DArray(m,n);
    Print2DArray(array);
    Console.WriteLine();
    Reparir2DArray(array);
    Print2DArray(array);
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

void Reparir2DArray(int[,] array)
{
     for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)  array[i, j] = array[i, j] * array[i, j];
        }
    }
}



// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
/*1 4 7 2
  5 9 2 3
  8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/

/*try
{
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    int[,] array = Create2DArray(m,n);
    Print2DArray(array);
    int sum = FindElements(array);
    PrintElements (sum);
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
            array[i,j] = random.Next(1,100);
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

int FindElements(int[,]array)
{
    int sum = 0;
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sum += array[i, j];
        }
    }

    return sum;
}

void PrintElements(int sum)
{
    Console.WriteLine($"Сумма элемеетов по главной диоганали = {sum}");
}*/







// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

/*try
{
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    int[,] array = Create2DArray(m,n);
    Print2DArray(array);
    GetRevers(array);
    Console.WriteLine();
    Print2DArray(array);
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

void GetRevers(int[,]array)
{
    int revers;
    for (var i = 0; i < array.GetLength(1); i++)
    {
        revers  = array[0,i];
        array[0,i] = array[array.GetLength(0) - 1, i];
        array [array.GetLength(0)-1, i] = revers;

    }
  
}*/
