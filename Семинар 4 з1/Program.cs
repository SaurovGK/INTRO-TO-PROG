// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// первый шаг - сгенерить функцию массива для произвольного числа элементов (максимально универсально)
// задача функции - создать массив целых чисел
// второй шаг - внутри функции создать результирующий массив
// по всему массиву нужно пройтись циклом фор, тк мы знаем кол-во раз, которое нужно пройтись
// нужно обратиться к каждой ячейке и создать в ней случайное число
// возвращаем массив

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

Console.Clear();

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));

int positiveSum = 0;
int negativeSum = 0;

foreach (int element in array)
{
   // if (element > 0)
   // {
   //     positiveSum += elememt
   // }
   // тернарный оператор:
   positiveSum += element > 0 ? element : 0;
   negativeSum += element < 0 ? element : 0;
}

Console.WriteLine($"Сумма положительных чисел равна: {positiveSum}, а отрицательных: {negativeSum}");

