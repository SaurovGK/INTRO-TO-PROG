// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.Clear();

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int NatNum (int num)
{
    if (num == 1)
    {
        return 1;
    }
    else 
    {
        Console.Write ($"{num}, ");
        num = NatNum (num-1);
    }
    return num;
}

int n = InputNum ("Введтите число N: ");
Console.WriteLine (NatNum (n));