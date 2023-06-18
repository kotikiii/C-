

// get three nums and check if its possible to build a triangle with those given three side-nums.

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckTriangle(a, b, c));

bool CheckTriangle (int a, int b, int c)
{
    return a < b + c & b < a + c & c < a + b;
}

