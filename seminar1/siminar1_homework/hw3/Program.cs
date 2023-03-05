// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Pull the number");
int a = Convert.ToInt32(Console.ReadLine());
int result = a % 2;

if (result == 0)
{
 Console.WriteLine("The number is even");
}

else{
Console.WriteLine("The number is not even");
}