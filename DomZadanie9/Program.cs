// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Решение:


/*int numberN = int.Parse(Console.ReadLine());
Console.WriteLine();
AllNaturalNumbersOfNbToOne(numberN);
void AllNaturalNumbersOfNbToOne(int numberN)
{

    if(numberN == 0)
    {
        return;
    }
   numberN--;

    Console.WriteLine($"{numberN+1}, ");
    

    AllNaturalNumbersOfNbToOne(numberN);
}*/





// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*int numberM = int.Parse(Console.ReadLine());
int numberN = int.Parse(Console.ReadLine());
Console.WriteLine(SumElemets(numberM, numberN));

int SumElemets(int m, int n)
{
  int sum = 0;
  if(m <= n)
    {
      sum += m;
      m++;
    }
    else
    {
        return sum;
    }

  
  return sum  + SumElemets(m,n);
}*/



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int m = InputInt("Введите numberM: ");
int n = InputInt("Введите numberN: ");
Console.WriteLine($"A({m}, {n}) = {FunctionAkkerman(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int FunctionAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return FunctionAkkerman(m - 1, 1);
    else
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}