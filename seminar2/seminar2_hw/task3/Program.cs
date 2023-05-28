
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Pull number of a week day");
int weekNumber = Convert.ToInt32(Console.ReadLine());

if (weekNumber == 1 || weekNumber == 2 || weekNumber == 3 || weekNumber == 4)
{
    Console.WriteLine("No! It's not a weekend!");
}

if (weekNumber == 6 || weekNumber == 7)
{
    Console.WriteLine("Yes, It's a weekend!");
}