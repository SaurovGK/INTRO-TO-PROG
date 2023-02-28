// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

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

int CountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            count = count + array[i];
        }
    }
    return count;
}

int[] array = GetArray(4, 1, 10);
Console.WriteLine(String.Join(", ", array));

int count = CountNumbers(array);
Console.WriteLine(count);
