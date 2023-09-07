

int Factorial(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }
    return result;
}

int FacRec(int n)
{
    if (n == 1) return 1;
    else return FacRec(n - 1) * n;
}

Console.WriteLine(Factorial(4));
//Console.WriteLine(FacRec(4));


int aTOnDegree(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result = result * a;
    }
    return result;
}

int PowerRec(int a, int n)
{
    if (n == 1) return a;
    else return a * PowerRec(a, n - 1);
}

Console.WriteLine(aTOnDegree(3, 3));
Console.WriteLine(PowerRec(3, 3));