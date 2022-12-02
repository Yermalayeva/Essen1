// напишите программу, которая будет выдавать
// названия недели по заданному номеру
// Например: 3->Среда 5->Пятница

Console.WriteLine("Введите номер недели от 1 до 7 включительно - ");
int num = int.Parse(Console.ReadLine());

if(num > 0 & num <=7)
{
    if(num == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if(num == 2)
    {
        Console.WriteLine("Вторник");
    }
    if(num == 3)
    {
        Console.WriteLine("Среда");
    }
    if(num == 4)
    {
        Console.WriteLine("Четверг");
    }
    if(num == 5)
    {
        Console.WriteLine("Пятница");
    }
    if(num == 6)
    {
        Console.WriteLine("Суббота");
    }
    if(num == 7)
    {
        Console.WriteLine("Вщскременье");
    }
}
else
{
    Console.WriteLine("Некорректный номер недели");
}