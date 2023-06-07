

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Pull a number");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number == (number % 10) * 10000 + ((number % 100) / 10) * 1000 + number % 1000)
// {
//     Console.WriteLine("yes " + number);
// }
// else
// {
//     Console.WriteLine("no");
// }

int number = Convert.ToInt32(Console.ReadLine());

bool Check ( int n )
{
    string newN = Convert.ToString(n);
    int a = 0;
    int b = 0;
    for (int i = 0; i <2; i++)
    {
        for (int j = 4; j > 2; j=j-1)
        {
            a = newN[i];
            b = newN[j];
        }
    };
    return a==b;
}

bool isItPalindrom = Check(number);

if (isItPalindrom) {
    Console.WriteLine("yes");
}
else {
    Console.WriteLine("no");
}

