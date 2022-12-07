// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// Например: A (3,6); B (2,1) -> 5,09; A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A(X, Y)   ");
int X1 = int.Parse(Console.ReadLine());
int Y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B(X, Y)   ");
int X2 = int.Parse(Console.ReadLine());
int Y2 = int.Parse(Console.ReadLine());

double G = Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1));

Console.WriteLine(G);