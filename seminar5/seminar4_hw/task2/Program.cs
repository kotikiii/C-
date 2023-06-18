

//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = new int[5];

int[] FillArray(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-10, 11);
    }
    return arr;
}

void EvenNumsSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((i + 1) % 2 == 0)
        {
            sum = sum + arr[i];
        }
    }
    Console.Write(sum);
}

void PrintArr(int[] arr)
{
    Console.WriteLine(string.Join(" , ", arr));
}

PrintArr(FillArray(array));
EvenNumsSum(array);