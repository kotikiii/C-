
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

int[] array = newArray[8];
Console.WriteLine(printArray(array));

int interval(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int intervalA = interval("Pull maxsimum possible value");
int intervalB = interval("Pull minimal possible value");

int newArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        int num = Random.Shared.Next(intervalB, intervalA + 1);
        array[i] = num;
    }
    return array;
}

void printArray (int [] array){
Console.WriteLine(string.Join(", ", newArray));
}