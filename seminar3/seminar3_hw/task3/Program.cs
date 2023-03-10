

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Pull a nember: ");
int N = Convert.ToInt32(Console.ReadLine());

int numbers = 1;
while (numbers <= N)
{
    double cubed = Math.Pow( numbers , 3);
    Console.Write(" " + cubed);
    numbers++;
}