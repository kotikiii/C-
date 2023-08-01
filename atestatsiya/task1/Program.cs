// Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumberFromN(int n )
{
    //string result = string.Empty;
    if(n>0) return $"{n} " + NumberFromN(n-1);
    else return string.Empty;
}

Console.WriteLine(NumberFromN(5));