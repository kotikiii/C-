
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Pull a number: ");
int ThreeDigitNumber = Convert.ToInt32(Console.ReadLine());

int lastTwoDigits = ThreeDigitNumber % 100;
int middleDigit = lastTwoDigits / 10;

Console.WriteLine(middleDigit);