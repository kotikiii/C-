
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Pull a number ");
int N = Convert.ToInt32(Console.ReadLine());

int numbers = 1;

while ( numbers <= N)
{
   double sqearedNumbers = Math.Pow( numbers, 2);
   Console.Write(" " + sqearedNumbers);
   numbers = numbers + 1;
}

