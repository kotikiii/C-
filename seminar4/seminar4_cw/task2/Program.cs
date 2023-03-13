// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.WriteLine("Pull a number: ");

int numberOfDigit(int n)
{
    int digits = 1;
    while (n > 10)
    {
        n /= 10;
        digits++;
    }
    return digits;
}

int number = Convert.ToInt32(Console.ReadLine());
int res = numberOfDigit(number);
Console.WriteLine(res);
