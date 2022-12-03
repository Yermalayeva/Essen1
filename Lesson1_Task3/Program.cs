// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// Например: 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"
Console.WriteLine("Введите число");
int n = Math.Abs(int.Parse(Console.ReadLine()));
int num = -(n+1);
while(n!=num)
{
    Console.Write(n);
    Console.Write(", ");
    n--;
}
