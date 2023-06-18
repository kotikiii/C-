


int[,] array = GenerateRandom2DMassive(3,3);
Print2Darray(array);
Console.WriteLine();
SquareValuesWithEvenIndexed(array);
Print2Darray(array);


void SquareValuesWithEvenIndexed(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i, j] = (int)Math.Pow(array[i, j], 2);
        }
    }
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