

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Pull a number");
int number = Convert.ToInt32(Console.ReadLine());

if (number == (number % 10) * 10000 + ((number % 100) / 10) * 1000 + number % 1000)
{
    Console.WriteLine("yes " + number);
}
else
{
    Console.WriteLine("no");
}