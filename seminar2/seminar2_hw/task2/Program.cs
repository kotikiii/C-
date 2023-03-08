
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Pull a number: ");
int usersNumber = Convert.ToInt32(Console.ReadLine());

if (usersNumber < 100)
{
    Console.WriteLine("Third digit does not exist");
}

if (usersNumber >= 100 && usersNumber < 1000)
{
    int thirdDigit = usersNumber % 10;
    Console.WriteLine(thirdDigit);
}

if (usersNumber >= 1000 && usersNumber < 10000)
{
    int lastTwoDigits = usersNumber % 100;
    int thirdDigit = lastTwoDigits / 10;
    Console.WriteLine(thirdDigit);
}

if (usersNumber >= 10000 && usersNumber < 100000)
{
    int lastThreeDigits = usersNumber % 1000;
    int thirdDigit = lastThreeDigits / 100;
    Console.WriteLine(thirdDigit);
}
