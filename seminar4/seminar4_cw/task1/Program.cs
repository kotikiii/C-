
int ReadIntNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int sumFrom1ToA(int a)
{
    int sum = 0;

    for (int i = 1; i <= a; i++)
    {
       sum = sum + i;
       // sum += i;
    }
    
    return sum;
}

int number = ReadIntNumber("Pull a number: ");
int result = sumFrom1ToA(number);

Console.WriteLine($"Sum of the numbers from 1 to {number} is {result}");