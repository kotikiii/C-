// reverse the massive

int[] array = new int[] { 1, 5, 9, 0, 2 };

void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(" , ", arr));
}


void Reverse(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = temp;
    }
}

Reverse(array);
PrintArray(array);
