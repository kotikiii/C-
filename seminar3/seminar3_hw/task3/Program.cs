

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Pull a number: ");
int N = int.Parse(Console.ReadLine());

void PrintCubed(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write( Math.Pow(i, 3));
        Console.Write(" ");
    }
}

PrintCubed(N);

// int numbers = 1;
// while (numbers <= N)
// {
//     double cubed = Math.Pow( numbers , 3);
//     Console.Write(" " + cubed);
//     numbers++;
// }