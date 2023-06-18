
// copying massive 

int[] array = new int[] { 1, 2, 3, 4, 5 };
int[] array2 = Copy(array);

array2[1] = 123;

int[] Copy(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(" , ", array));
}

PrintArray(array);
PrintArray(array2);
