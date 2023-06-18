
// first N terms of Fibonacci numbers//
// n = 7 => 0, 1, 1, 2, 3, 5, 8.

int n = int.Parse(Console.ReadLine());

void FibonacciNums(int n)
{
    int firstNum = 0;
    int secondNum = 1;

    Console.Write("0 ");
    Console.Write("1 ");

    int sum = 0;
    for (int i = 2; i < n; i++)
    {
        sum = firstNum + secondNum;
        firstNum = secondNum;
        secondNum = sum;
        Console.Write( sum );
        Console.Write(" ");
    }
}

FibonacciNums(n);

