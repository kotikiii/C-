
int[,] array = Generate2DRandomArray(4, 4);
Print2DArray(array);
(int row, int column) = GetIndexesOfMinElement(array);
Console.WriteLine($"[{row}, {column}]");

int[,] result = DeletingRowAndColumnOfMinElement(array, row, column);
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

//returns two values
(int, int) GetIndexesOfMinElement(int[,] array)
{
    int minElement = array[0, 0];
    int rowIndex = 0;
    int columnIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minElement > array[i, j])
            {
                minElement = array[i, j];
                rowIndex = i;
                columnIndex = j;
            }
        }
    }
    return (rowIndex, columnIndex);
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

int[,] DeletingRowAndColumnOfMinElement(int[,] array, int row, int column)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0, k = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0, t = 0; j < array.GetLength(1); j++)
        {
            if (i != row & j != column)
            {
                result[k, t] = array[i, j];
                t++;
            }
        }

        if (i != row)
        {
            k++;
        }
    }
    return result;
}
