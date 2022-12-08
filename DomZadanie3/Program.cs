// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Например: 14212 -> нет; 12821 -> да; 23432 -> да.

// Вариант1:
/*Console.WriteLine("Введите пятизначное число: ");
int Number = int.Parse(Console.ReadLine());

int [] array = new int[5];
int k = 0;

while(Number > 0)
{
    int X = Number/ 10;
    int O = Number - X * 10;
    Number = X;
    array[k] = O;
    k++;
}

if(array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("Да! Число является палиндромом!");
}
else
{
    Console.WriteLine("Нет! Число  не является палиндромом!");
}*/

/* Вариант2 (более универсален)
Console.WriteLine("Введите пятизначное число: ");
int Number = int.Parse(Console.ReadLine());

int [] array = new int[5];
int k = 0;

while(Number > 0)
{
    int X = Number/ 10;
    int O = Number - X * 10;
    Number = X;
    array[k] = O;
    k++;
}

for(int i = 0; i < k/2; i++)
{
    if(array[i] != array[k-i-1])
    {
        Console.WriteLine("Нет! Число  не является палиндромом!");
        return;
    }
}
Console.WriteLine("Да!Число является палиндромом! ");*/


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Например: A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53

/*Console.WriteLine("Введите координаты точки A(X, Y, Z)   ");
int X1 = int.Parse(Console.ReadLine());
int Y1 = int.Parse(Console.ReadLine());
int Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B(X, Y, Z)   ");
int X2 = int.Parse(Console.ReadLine());
int Y2 = int.Parse(Console.ReadLine());
int Z2 = int.Parse(Console.ReadLine());

double G = Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1) + (Z2 - Z1) * (Z2 - Z1));

Console.WriteLine(G);*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Например: 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125.

Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine());
int [] cube = Calculate(Number);

PrintArray(cube);

int [] Calculate(int N)
{
    int [] array = new int[N];
    for(int i = 0; i < N; i++)
    {
        array[i] = (i + 1) * (i + 1)* (i + 1);
    }
    return array;
}

void PrintArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

