// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа.
// Например: 5 -> 2, 4; 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

for(int i = 1; i <= N; i++)
   if(i % 2 == 0)
   {
     Console.WriteLine(i);
   }


