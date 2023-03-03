
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Pull the first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Pull the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > b)
{
    Console.WriteLine("max = " + max);
}

else
{
    max = b;
    Console.WriteLine("max = " + max);
}
