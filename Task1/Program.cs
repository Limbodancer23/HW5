#nullable disable
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] newArray = RandArray(5, 0, 1000);
System.Console.WriteLine(String.Join(" ", newArray));
int countPos = EvenMeth(0);
System.Console.WriteLine($"Amount of positive numbers = {countPos}");


int EvenMeth(int count)
{;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] RandArray(int size, int min, int max)
{
    int[] value = new int[size];
    for (int i = 0; i < size; i++)
    {
        value[i] = new Random { }.Next(min, max);
    }
    return value;
}