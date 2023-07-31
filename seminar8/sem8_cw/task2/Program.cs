// turning rows to the columns by changing their values.

int[,] array1 = Generate2DRandomArray(1, 3);
Print2DArray(array1);
Console.WriteLine();
int[,] result = SwapRowsAndColumns(array1);
Print2DArray(result);

int[,] Generate2DRandomArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
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

int[,] SwapRowsAndColumns(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];

    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("not possible");
    }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result[i, j] = array[j, i];
            }
        }
    return result;
}
