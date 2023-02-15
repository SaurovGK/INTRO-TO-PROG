// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.Write("Введите число 1: ");
int x = int.Parse(Console.ReadLine()!);

Console.Write("Введите число 2: ");
int y = int.Parse(Console.ReadLine()!);

Console.Write("Введите число 3: ");
int z = int.Parse(Console.ReadLine()!);

int max = x;

if (x < y) {
    max = y;
}

if (max < z) {
    max = z;
}

Console.WriteLine($"Максимальное число = {max}");
