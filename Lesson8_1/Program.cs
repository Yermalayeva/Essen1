// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
/*1, 2, 3 
//4, 6, 1
//2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза*/


/*Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());
int[,] array = Create2DArray(m,n);
Print2DArray(array);
Console.WriteLine("Введите значение элемента:");
int number = int.Parse(Console.ReadLine());
    //GetElement(array);
Console.WriteLine($"{number} повторяется     " + GetElement(array) + "  раз(а)");



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
int GetElement(int[,]array)
{
    int index = 0;
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if(number == array[i,j])
            index++;
        }
    }
    return index;
}*/



////////////////////////////////////////
//Второй способ при помощи 

//int m = InputInt("Введите число строк: ");
//int n = InputInt("Введите число столбцов: ");
Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());
int[,] array = Create2DArray(m,n);
Print2DArray(array);

List <(int number, int frequence)> dictionary = FindFrequence(array);
Console.WriteLine(string.Join("\n", dictionary));

List <(int number, int frequence)> FindFrequence(int[,]array)
{
    List <(int number, int count)> dictionary = new List<(int,int)>();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            int index = FindIndex(dictionary, array[i,j]);
            if(index != -1)
            {
                dictionary[index] = (array[i,j], dictionary[index].count + 1);
            }
            else
            {
                dictionary.Add((array[i,j],1));
            }
        }
        
    }
    return dictionary;
}

int FindIndex(List <(int,int)> list, int number)
{
    for(int i = 0; i < list.Count; i++)
    {
        if(list[i].Item1 == number)
        {
            return i;
        }
    }
    return -1;
}

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
