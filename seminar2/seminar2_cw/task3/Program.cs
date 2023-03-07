

Console.WriteLine("Pull the number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0)
{
  Console.WriteLine("Divisable by 7 and 23");
}

else {
    Console.WriteLine("Non-Divisable by 7 or/and 23");
}