                            // (minValue, maxValue]
int randomNumber = Random.Shared.Next(10, 100); 
Console.WriteLine(randomNumber);

int firstDigit = randomNumber / 10;
Console.WriteLine("The first digit is " + firstDigit);

int lastDigit = randomNumber % 10;
Console.WriteLine("The last digit is " + lastDigit);

if (lastDigit>firstDigit)
{
    Console.WriteLine("The max is " + lastDigit);
}

else {
        Console.WriteLine("The max is " + firstDigit);
}