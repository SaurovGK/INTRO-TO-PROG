// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве. 

Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int CountNumbers (int[] array)
{
    int count = 0;
    foreach(int element in array)
    {
        if (element % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(5, 100, 999);
Console.WriteLine(String.Join(", ", array));

int count = CountNumbers(array);
Console.WriteLine(count);
