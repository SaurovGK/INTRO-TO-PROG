// Напишите прогу, которая по заданному номеру четверти
// показывает диапозон возможных координат точек в этой четверти (x и y)

Console.Clear();
Console.Write("Введите номер четверти:  ");

int quot = int.Parse(Console.ReadLine()!);

switch(quot)
{
    case 1:
        Console.WriteLine("X > 0; Y > 0");
        break;
    case 2:
        Console.WriteLine("X < 0; Y > 0");
        break;
    case 3:
        Console.WriteLine("X < 0; Y < 0");
        break;
    case 4:
        Console.WriteLine("X > 0; Y < 0");
        break;
    default:
        Console.WriteLine("Опечатка");
        break;
}