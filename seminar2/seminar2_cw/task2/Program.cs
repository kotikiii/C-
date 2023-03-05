

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Pull the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pull the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine("кратно");
}

else
{
    int remainder = a % b;
    Console.WriteLine("не кратно, остаток: " + remainder);
}