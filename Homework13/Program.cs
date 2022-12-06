// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Например: 645 -> 5; 78 -> 78 -> третьей цифры нет; 32679 -> 6

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int [] M = new int [50];
int k = 0;

while(N > 0)
{
    int X = N / 10;
    int O = N - X * 10;
    N = X;
    M[k] = O;
    k++;
}
if(k > 2)
{
    Console.WriteLine(M[k - 3]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}