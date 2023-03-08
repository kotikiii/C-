

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Pull one of the FOUR quarters: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1)
{
    Console.WriteLine(" x > 0 and y > 0");
}
else if (quarter == 2)
{
    Console.WriteLine(" x < 0 and y > 0");
}
else if ( quarter == 3)
{
    Console.WriteLine(" x < 0 and y < 0");
}
else if ( quarter == 4)
{
    Console.WriteLine(" x > 0 and y < 0");
}
else {
    Console.WriteLine("Unable to determine the quarter");
}