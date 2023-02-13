#nullable disable
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] Arr1 = RandArray(10, -99, 100);
System.Console.WriteLine(String.Join(' ', Arr1));
int findSumm = summMeth(0);
System.Console.WriteLine(findSumm);




int[] RandArray(int size, int minVal, int maxVal)
{
    int[] matrix = new int[size];
    for (int i = 0; i < size; i++)
    {
        matrix[i] = new Random{}. Next(minVal, maxVal);
    }
    return matrix;
}
int summMeth(int summ)
{
    for (int i = 0; i < Arr1.Length; i++)
    {

        if(i % 2 != 0)
        {
            summ+=Arr1[i];
        }
    }
    return summ;
}
