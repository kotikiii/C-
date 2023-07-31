
int[] array = GetRandom1DArray(5, 0, 4);
Print1DArray(array);
Console.WriteLine();
GetNumbersApearedInArray(array);

int[] GetRandom1DArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
    return array;
}

void Print1DArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}

int GetCount(int[] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            count++;
        }
    }
    return count;
}

void GetNumbersApearedInArray(int[] array)
{
   HashSet<int> number = new HashSet<int>();

   for (int i = 0; i < array.Length; i++)
   {
        if(!number.Contains(array[i]))
        {
            int count = GetCount(array, array[i]);
            Console.WriteLine($"{array[i]} appears {count} times");

            number.Add(array[i]);
        }
   }
}

