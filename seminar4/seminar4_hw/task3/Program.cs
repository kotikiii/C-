
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


int length = Convert.ToInt32(Console.ReadLine());

int[] FillRandomArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(1, 31);
    }
    return array;
}

void Print(int[] arr)
{
    int j = 0;
    while (j < arr.Length)
    {
        Console.Write(arr[j] + " ");
        j++;
    }
}

Print(FillRandomArray(length));
