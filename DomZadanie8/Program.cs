// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());
int[,] array = Create2DArray(m,n);
Print2DArray(array);
Console.WriteLine();

Console.WriteLine($"Новый массив: ");
GetSortingArray(array);
Print2DArray(array);


int[,] Create2DArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m,n];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1,10);
        }
    }

    return array;
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

void GetSortingArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int s = 0; s < array.GetLength(1) - 1; s++)
      {
        if (array[i, s] < array[i, s + 1])
        {
          int temp = array[i, s + 1];
          array[i, s + 1] = array[i, s];
          array[i, s] = temp;
        }
      }
    }
  }
}*/



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
/* 1 4 7 2
   5 9 2 3
   8 4 2 4
   5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

/*Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());
int[,] array = Create2DArray(m,n);
Print2DArray(array);
Console.WriteLine();


int[,] Create2DArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m,n];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1,10);
        }
    }

    return array;
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

int minSum = 0;
int sum = GetSumRow(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSum = GetSumRow(array, i);
  if (sum > tempSum)
  {
    sum = tempSum;
    minSum = i;
  }
}


int GetSumRow(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSum +1} строка");*/

//////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*Console.WriteLine("Введите число строк для matrix1 m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов для matrix1 n:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число строк для matrix2 b:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов для matrix2 c:");
int c = int.Parse(Console.ReadLine());

int[,] matrix1 = new int[m,n];
Create2DArray(matrix1);
Console.WriteLine();
Print2DArray(matrix1);

int[,] matrix2 = new int[b,c];
Create2DArray(matrix2);
Console.WriteLine();
Print2DArray(matrix2);

int [,] matrixResult = GetMatrixProizvedenie(matrix1, matrix2);


if(matrixResult.GetLength(0) == 0)
{
  Console.WriteLine("Умножение невозможно! Кол-во столбцов 1 матрицы не равно кол-ву строк 2 матрицы. Введите новые значения");
}
else
{
  Console.WriteLine("Произведение матриц равно:   ");
}

Print2DArray(matrixResult);

void Create2DArray(int [,] array)
{
    
    Random random = new Random();
    //int[,] matrix1 = new int[m,n];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1,10);
        }
    }
    
    
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
 


int[,] GetMatrixProizvedenie(int [,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[m,c];
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        matrixResult = new int[0,0];
        return matrixResult;
    }
    
    //return matrixResult;
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrixResult[i,j] =  0;
            for(int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrixResult[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }

    return matrixResult;
}*/





//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*Console.WriteLine("Введите x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y:");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z:");
int z = int.Parse(Console.ReadLine());

//int[,,] array = Create3DArray(x,y,z);
int[,,] array = new int[x,y,z];
Create3DArray(array);

Print3DArray(array);
Console.WriteLine();

void Create3DArray(int[,,] array)
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void Print3DArray(int[,,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
          for (var k = 0; k < array.GetLength(1); k++)
          {
            Console.Write($"{array[i,j,k]}({i} {j} {k}) ");
          }
        }
        Console.WriteLine();
    }
}
*/



////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/*Console.WriteLine("Введите размерность массива n");
int n = int.Parse(Console.ReadLine());
int[,] arraySpiral = new int[n, n];

int number = 1;
int i = 0;
int j = 0;

while (number <= arraySpiral.GetLength(0) * arraySpiral.GetLength(1))
{
  arraySpiral[i, j] = number;
  number++;
  if (i <= j + 1 && i + j < arraySpiral.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= arraySpiral.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > arraySpiral.GetLength(1) - 1)
    j--;
  else
    i--;
}

Print2DArray(arraySpiral);

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
            {
                Console.Write($"0{array[i, j]} ");
            }
            else
            {
                Console.Write($"{array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}*/



