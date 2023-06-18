
//Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//(1,7) -> такого числа в массиве нет
//(0,0) -> 1

int[,] array = GenerateRandom2DMassive(3, 3);
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
Print2Darray(array);
FindValueByIndexes(array, i, j);

int[,] GenerateRandom2DMassive(int a, int b)
{
    int[,] array = new int[a, b];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void Print2Darray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindValueByIndexes(int[,] array, int a, int b)
{
    int value = 0;
    if (array.GetLength(0) > a & array.GetLength(1) > b)
    {
        value = array[a, b];
        Console.WriteLine(value);
    }
    else Console.WriteLine("No value exists with those indexes!");
    return value;
}