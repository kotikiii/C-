
// Задайте значения M и N.
//  Напишите программу, которая найдёт сумму натуральных элементов 
//  в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumFromMtoN(int m, int n)
{
    if(m==n) return m;
    else return m + SumFromMtoN(m + 1, n);
}

Console.WriteLine(SumFromMtoN(4, 8));