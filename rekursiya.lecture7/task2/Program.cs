

int SumFrom1ToN(int n)
{
    int sum = 0;
    for (int i = 0; i <= n; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int SumRec(int n)
{
    if(n==0) return 0;
    else return n + SumRec(n-1);
}

Console.WriteLine(SumFrom1ToN(4));
Console.WriteLine(SumRec(4));
