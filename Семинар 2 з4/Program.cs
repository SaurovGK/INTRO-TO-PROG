// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Clear();

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);

int min = num1, max = num2;
if(min > num2)
{
    min = num2;
    max = num1;
}

int q = min * min;

if (q == max) Console.WriteLine($"{max} является квадратом {min}");
else Console.WriteLine($"{max} не является квадратом {min}");



