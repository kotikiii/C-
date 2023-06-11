

Console.WriteLine("Pull a number ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 1;

while (current <= N)
{
    if (current % 2 == 0)
    {
        Console.Write(current + " ");
    }
    current++;
}

