
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

Console.Write("Pull number of strings - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Pull number of columns - ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = GenerateRandom2DMassive(m, n);
Print2Darray(array);
