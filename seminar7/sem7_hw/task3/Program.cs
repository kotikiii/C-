
//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = GenerateRandom2DMassive(3, 4);
Print2Darray(array);

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

void ArithmeticMeanOfColumn(int[,] array)
{
    int j = 0;
    while (j < array.GetLength(1))
    {
        int i = 0;
        double sum = 0;
        while (i < array.GetLength(0))
        {
            sum += array[i, j];
            i++;
        }
        Console.Write($"{sum / array.GetLength(0)} ");
        j++;
    }
}
ArithmeticMeanOfColumn(array);
