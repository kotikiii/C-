
//Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран. Данные вводятся с консоли пользователем


int messageToUser(string mes)
{
    Console.Write(mes);
    int infoFromUser = Convert.ToInt32(Console.ReadLine());
    return infoFromUser;
}

int [] massive(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Random.Shared.Next(minValue, maxValue + 1);
    }
    return array;
}
 void PrintArray ( int[] array )
 {
    Console.Write("{");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]},  ");
    }
    Console.Write("}");
 }

int size = messageToUser("pull length of a massive ");
int MinValue = messageToUser("pull min value ");
int MaxValue = messageToUser("pull max value ");
int [] fillArray = massive( size, MinValue, MaxValue);
PrintArray (fillArray);

