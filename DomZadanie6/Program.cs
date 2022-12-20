// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Например: 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 4.

/*Console.Write("Введите количество элементов массива: ");
int elementCount = int.Parse(Console.ReadLine());
int [] numbers = CreatArray(elementCount);


int []CreatArray(int elementCount)
{
    int [] array = new int[elementCount];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

PrintArray(numbers);

void PrintArray(int [] array)
{
    Console.Write("[");
    for(var i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

GetSumNumberMoreZero(numbers);

int GetSumNumberMoreZero(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            sum++;
        }

    }
    return sum;
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {GetSumNumberMoreZero(numbers) }");*/





//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Например: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*Console.WriteLine("Введите значения первой прямой(b1, k1): ");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения второй прямой(b2, k2): ");
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());


double[] array = GetTochkaPeresechenia(b1, k1, b2, k2);

//Console.WriteLine($"Точка пересечения двух прямыx: ( {array[0]}, {array[1]} )");
Console.WriteLine($"Точка пересечения двух прямыx:  ({string.Join("; ",array)})");

double [] GetTochkaPeresechenia(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1  - k2);
    double y =  k2 * x + b2;
    double [] array = new double[2]{x, y};
    return array;
}*/

Console.WriteLine("Введите значения первой прямой(b1, k1): ");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения второй прямой(b2, k2): ");
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());


double[] array = GetTochkaPeresechenia(b1, k1, b2, k2);

if(array.Length == 0)
{
    Console.WriteLine("Прямые паралелльны");
}

else
{
    Console.WriteLine($"Точка пересечения двух прямыx: ( {array[0]}, {array[1]} )");
    //Console.WriteLine($"Точка пересечения двух прямыx:  ({string.Join("; ",array)})");
}

double [] GetTochkaPeresechenia(double b1, double k1, double b2, double k2)
{
    double[] array;
    if(k1 == k2)
    {
        array = new double[0];
    }
    

    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        array = new double[2] { x, y };
    }
    
    return array;
    
}



/*if(k1 = k2)
{

    double x == 0;
    
}
Console.WriteLine("Прямые паралелльны");
//Console.WriteLine($"Точка пересечения двух прямыx:( {x},  {y})");*/


