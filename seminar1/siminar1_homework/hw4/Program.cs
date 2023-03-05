// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Pull a number ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 1;

while (current <= N)
{
    if (current % 2 == 0)
    {
        Console.Write(current + " ");
    }
    current = current + 1;
}

