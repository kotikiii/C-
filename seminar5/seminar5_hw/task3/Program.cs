//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[] { 12.3, 234.5, 5.7, 1.5, 34.6 };

double FindMin(double[] arr)
{
    int i = 0;
    double min = arr[i];
    while (i < arr.Length)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        i++;
    }
    return min;
}
double FindMax(double[] arr)
{
    int i = 0;
    double max = arr[i];
    while (i < arr.Length)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        i++;
    }
    return max;
}

double maxValue = FindMax(array);
double minValue = FindMin(array);
Console.Write(maxValue-minValue);
