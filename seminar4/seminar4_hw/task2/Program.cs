
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int userNumber(string messageToUser)
{
    Console.Write(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int summOfDigits(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
int number = userNumber("Pull your number: ");
int res = summOfDigits(number);
System.Console.WriteLine(res);