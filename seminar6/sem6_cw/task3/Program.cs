
/*verevesti 10tichnoe chislp v 2ichnoe*/

int number = int.Parse(Console.ReadLine());

string ToBinary(int number)
{
    string result = string.Empty;
    while (number != 0)
    {
        result = number % 2 + result;
        number = number / 2;
    }
    return result;
}

Console.WriteLine(ToBinary(number));