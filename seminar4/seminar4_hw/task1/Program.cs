
// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int userNumber(string messageToUser)
{
    Console.Write(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int A = userNumber("Pull number A: ");
int B = userNumber("Pull number B: ");

int Power(int A, int B)
{
    int AofB = 1;
    for (int i = 1; i <= B; i++)
    {
        AofB = AofB * A;
    }
    return AofB;
}

int result = Power(A, B);
Console.WriteLine(result);



