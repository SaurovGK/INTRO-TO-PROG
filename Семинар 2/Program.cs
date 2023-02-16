// Программа, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine()!);
int count = 1;
while (count <= x)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
   
    count++;
}