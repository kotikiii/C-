
int[,] array = GenerateRandom2DMassive(4, 4);
Print2Darray(array);

int sum = GetSumOfValuesOnDiagonal(array);
Console.WriteLine($"sum is {sum}");


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

int GetSumOfValuesOnDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < Math.Min(array.GetLength(0), array.GetLength(1)); i++)
    {
        sum += array[i, i];
    }
    return sum;
}