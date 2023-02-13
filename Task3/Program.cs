#nullable disable
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] Arr1 = RandArray(5, 0, 10);
System.Console.WriteLine(String.Join(' ', Arr1));
double MaxNum = FindMax(0);
System.Console.WriteLine(MaxNum);
double MinNum = FindMin(Arr1[0]);
System.Console.WriteLine(MinNum);
double DiffNum = FindDiff(0, MinNum, MaxNum);
System.Console.WriteLine($"Difference between MaxNum and MinNum in array = {Math.Round(DiffNum, 2)}");

double FindDiff(double difRes, double minRes, double maxRes)
{
    difRes = maxRes - minRes;
    return difRes;
}
double FindMin(double min)
{
    for (int i = 0; i < Arr1.Length; i++)
    {
        if(Arr1[i] < min)
        {
            min = Arr1[i];
        }
    }
    return min;
}
double FindMax(double max)
{
    for (int i = 0; i < Arr1.Length; i++)
    {
        if(Arr1[i] > max)
        {
            max = Arr1[i];
        }
    }
    return max;
}
double[] RandArray(int size, int minVal, int maxVal)
{
    double[] matrix = new double[size];
    for (int i = 0; i < size; i++)
    {
        matrix[i] = new Random(). Next(minVal, maxVal) + new Random(). NextDouble();
    }
    return matrix;
}