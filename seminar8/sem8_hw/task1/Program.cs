//Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//  1 4 7 2  (0,0) (0,1) (0,2) (0,3)
//  5 9 2 3  (1,0) (1,1) (1,2) (1,3)
//  8 4 2 4  (2,0) (2,1) (2,2) (2,3)
// 
//  2 4 7 1
//  
//  
// В итоге получается вот такой массив:
// 7 4 2 1  (0,0) (0,1) (0,2) (0,3)
// 9 5 3 2  (1,0) (1,1) (1,2) (1,3)
// 8 4 4 2  (2,0) (2,1) (2,2) (2,3)

int[,] array = Generate2dRandomArray(3, 4);
Print2DArray(array);
Console.WriteLine();
int[,] result = GetSortedArray(array);
Print2DArray(result);

int[,] Generate2dRandomArray(int a, int b)
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
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] GetSortedArray(int[,] array)
{
    //int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    int maxInRow = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (maxInRow < array[i, j])
            {
                int temp = maxInRow;
                maxInRow = array[i, j];
                array[i, j] = temp;

                // int temp = array[0, j];
                // array[0, j] = array[array.GetLength(0) - 1, j];
                // array[array.GetLength(0) - 1, j] = temp;
            }
        }
    }
    return array;
}
