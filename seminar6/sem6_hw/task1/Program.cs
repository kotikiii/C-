
//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("number of digits: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];


PositiveNums(GetArray(length));

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"i = {i} number =  ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PositiveNums(int[] array)
{
    int count = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (array[i] < 0)
        {
            count++;
        }
        i++;
    }
    Console.WriteLine("Number of positive digits: " + count);
}

