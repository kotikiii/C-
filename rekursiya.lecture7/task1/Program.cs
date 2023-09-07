

string NumbersFrom( int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result =$"{result} {i}";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if(a<=b) return $"{a} " + NumbersRec(a+1, b);
    else return string.Empty;
}

Console.Write(NumbersFrom(1,10));
Console.WriteLine();
Console.Write(NumbersRec(1,10));